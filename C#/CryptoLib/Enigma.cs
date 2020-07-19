using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CryptoLib
{
    public static class Enigma
    {
        public static string Encrypt(string message, string rings, string rotors, string reflector, string plugs, string rotorStart)
        {
            return Start(message, rings, rotors, reflector, plugs, rotorStart);
        }
        public static string Decrypt(string message, string rings, string rotors, string reflector, string plugs, string rotorStart)
        {
            return Start(message, rings, rotors, reflector, plugs, rotorStart);
        }
        private static string Start(string message, string rings, string rotors, string reflector, string plugs, string rotorStart)
        {
            EnigmaMachine machine = new EnigmaMachine();
            EnigmaSettings eSettings = new EnigmaSettings();

            querySettings(eSettings, rings, rotors, reflector, plugs, rotorStart);

            //Message to  encrypt
            if (!Regex.IsMatch(message, @"^[a-zA-Z ]+$"))
            {
                return "Error: Only letters A-Z are allowed";
            }
            message = message.Replace(" ", "").ToUpper();

            // Enter settings on machine
            machine.setSettings(eSettings.rings, eSettings.grund, eSettings.order, eSettings.reflector);

            // The plugboard settings
            foreach (string plug in eSettings.plugs)
            {
                char[] p = plug.ToCharArray();
                machine.addPlug(p[0], p[1]);
            }

            return machine.runEnigma(message);
        }

        private static void querySettings(EnigmaSettings e, string rings, string rotors, string reflector, string plugs, string rotorStart)
        {
            string r = rings;
            string g = rotorStart;
            string ro = rotors;
            string re = reflector;
            string p = plugs;
            //Enter the ring settings (Ex. AAA, MCK, Default: AAA)
            if (r == "")
                e.rings = new char[] { 'A', 'A', 'A' };
            else
                e.rings = r.ToCharArray();

            //Rotor start settings (Ex. AAA, MCK, Default: AAA)
            if (g == "")
                e.grund = new char[] { 'A', 'A', 'A' };
            else
                e.grund = g.ToCharArray();

            //Order of the rotors (Ex. I-II-III, III-I-IV, V-II-IV Default: I-II-III)
            if (ro == "")
                e.order = "I-II-III";
            else
                e.order = ro;

            //Enter the reflector to use (A, B, or C, Default: B)
            if (re == "")
                e.reflector = 'B';
            else
                e.reflector = re.ToCharArray()[0];

            //Enter the plugboard configuration (Ex. KH AB CE IJ, Default: None)
            if (p == "")
                e.plugs.Clear();
            else
            {
                string[] plug = p.Split(' ');
                foreach (string s in plug)
                {
                    e.plugs.Add(s);
                }
            }
        }

        private class EnigmaSettings
        {
            public char[] rings { get; set; }
            public char[] grund { get; set; }
            public string order { get; set; }
            public char reflector { get; set; }
            public List<string> plugs = new List<string>();

            public EnigmaSettings()
            {
                setDefault();
            }

            public void setDefault()
            {
                rings = new char[] { 'A', 'A', 'A' };
                grund = new char[] { 'A', 'A', 'A' };
                order = "I-II-III";
                reflector = 'B';
                plugs.Clear();
            }
        }
    }
    public class EnigmaMachine
    {
        //Based around Enigma M3 Army 1938

        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string rotorI = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        private const string rotorII = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
        private const string rotorIII = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
        private const string rotorIV = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
        private const string rotorV = "VZBRGITYUPSDNHLXAWMJQOFECK";
        private const string reflectorA = "EJMZALYXVBWFCRQUONTSPIKHGD";
        private const string reflectorB = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
        private const string reflectorC = "FVPJIAOYEDRZXWGCTKUQSBNMHL";

        private Rotor[] rotors;
        private Rotor reflector;

        private Dictionary<Char, Char> plugBoard;

        public class Rotor
        {
            private int outerPosition;
            public char outerChar { get; set; }

            //Rotor Alphabet
            private string wiring;

            //Notch turn point
            private char turnOver;

            public string name { get; }

            public char ring { get; set; }

            public int[] map { get; }
            public int[] revMap { get; }

            public Rotor(string w, char to, string n)
            {
                turnOver = to;
                outerPosition = 0;

                ring = 'A';
                name = n;

                map = new int[26];
                revMap = new int[26];

                setWiring(w);
            }

            public void setWiring(string w)
            {
                wiring = w;
                outerChar = wiring.ToCharArray()[outerPosition];

                for (int i = 0; i < 26; i++)
                {
                    int match = ((int)wiring.ToCharArray()[i]) - 65;
                    map[i] = (26 + match - i) % 26;
                    revMap[match] = (26 + i - match) % 26;
                }
            }

            public void setOuterPosition(int i)
            {
                outerPosition = i;
                outerChar = alphabet.ToCharArray()[outerPosition];
            }
            public int getOuterPosition()
            {
                return outerPosition;
            }

            public void setOuterChar(char c)
            {
                outerChar = c;
                outerPosition = alphabet.IndexOf(outerChar);
            }

            public void step()
            {
                outerPosition = (outerPosition + 1) % 26;
                outerChar = alphabet.ToCharArray()[outerPosition];
            }

            public bool isInTurnOver()
            {
                return outerChar == turnOver;
            }
        }

        private void rotateRotors(Rotor[] r)
        {
            if (r.Length == 3)
            {
                if (r[1].isInTurnOver())
                {
                    r[0].step();
                    r[1].step();
                }
                else if (r[2].isInTurnOver())
                {
                    r[1].step();
                }

                r[2].step();
            }
        }

        private char rotorMap(char c, bool reverse)
        {
            int cPos = (int)c - 65;
            if (!reverse)
            {
                for (int i = rotors.Length - 1; i >= 0; i--)
                {
                    cPos = rotorValue(rotors[i], cPos, reverse);
                }
            }
            else
            {
                for (int i = 0; i < rotors.Length; i++)
                {
                    cPos = rotorValue(rotors[i], cPos, reverse);
                }
            }

            return alphabet.ToCharArray()[cPos];
        }

        private int rotorValue(Rotor r, int cPos, bool reverse)
        {
            int rPos = (int)r.ring - 65;
            int d;
            if (!reverse)
                d = r.map[(26 + cPos + r.getOuterPosition() - rPos) % 26];
            else
                d = r.revMap[(26 + cPos + r.getOuterPosition() - rPos) % 26];

            return (cPos + d) % 26;
        }

        private char reflectorMap(char c)
        {
            int cPos = (int)c - 65;
            cPos = (cPos + reflector.map[cPos]) % 26;
            return alphabet.ToCharArray()[cPos];
        }

        public EnigmaMachine()
        {
            plugBoard = new Dictionary<char, char>();

            // First argument is alphabet, second is the turnover notch
            Rotor rI = new Rotor(rotorI, 'Q', "I");
            Rotor rII = new Rotor(rotorII, 'E', "II");
            Rotor rIII = new Rotor(rotorIII, 'V', "III");
            Rotor rIV = new Rotor(rotorIV, 'J', "IV");
            Rotor rV = new Rotor(rotorV, 'Z', "V");
            rotors = new Rotor[] { rI, rII, rIII };
            reflector = new Rotor(reflectorA, ' ', "");
        }

        public void setReflector(char conf)
        {
            if (conf != 'A' && conf != 'B' && conf != 'C')
            {
                throw new ArgumentException("Invalid argument");
            }

            string wiring = "";
            switch (conf)
            {
                case 'A':
                    wiring = reflectorA;
                    break;
                case 'B':
                    wiring = reflectorB;
                    break;
                case 'C':
                    wiring = reflectorC;
                    break;
            }
            reflector.setWiring(wiring);
        }

        public void setSettings(char[] rings, char[] grund)
        {
            if (rings.Length != rotors.Length || grund.Length != rotors.Length)
            {
                throw new ArgumentException("Invalid argument lengths");
            }

            for (int i = 0; i < rotors.Length; i++)
            {
                rotors[i].ring = Char.ToUpper(rings[i]);
                rotors[i].setOuterChar(Char.ToUpper(grund[i]));
            }
        }

        public void setSettings(char[] rings, char[] grund, string rotorOrder)
        {
            Rotor rI = new Rotor(rotorI, 'Q', "I");
            Rotor rII = new Rotor(rotorII, 'E', "II");
            Rotor rIII = new Rotor(rotorIII, 'V', "III");
            Rotor rIV = new Rotor(rotorIV, 'J', "IV");
            Rotor rV = new Rotor(rotorV, 'Z', "V");

            // Get the current ordering
            for (int i = 0; i < rotors.Length; i++)
            {
                if (rotors[i].name == "I")
                    rI = rotors[i];
                if (rotors[i].name == "II")
                    rII = rotors[i];
                if (rotors[i].name == "III")
                    rIII = rotors[i];
                if (rotors[i].name == "IV")
                    rIV = rotors[i];
                if (rotors[i].name == "V")
                    rV = rotors[i];
            }

            string[] order = rotorOrder.Split('-');

            // Set the new ordering
            for (int i = 0; i < order.Length; i++)
            {
                if (order[i] == "I")
                    rotors[i] = rI;
                if (order[i] == "II")
                    rotors[i] = rII;
                if (order[i] == "III")
                    rotors[i] = rIII;
                if (order[i] == "IV")
                    rotors[i] = rIV;
                if (order[i] == "V")
                    rotors[i] = rV;

            }

            setSettings(rings, grund);
        }

        public void setSettings(char[] rings, char[] grund, string rotorOrder, char reflectorConf)
        {
            setReflector(reflectorConf);
            setSettings(rings, grund, rotorOrder);
        }

        public string runEnigma(string msg)
        {
            StringBuilder encryptedMessage = new StringBuilder();

            msg = msg.ToUpper();

            foreach (char c in msg)
            {
                encryptedMessage.Append(encryptChar(c));
            }

            return encryptedMessage.ToString();
        }

        private char encryptChar(char c)
        {

            rotateRotors(rotors);

            if (plugBoard.ContainsKey(c))
            {
                c = plugBoard[c];
            }
            c = rotorMap(c, false);

            c = reflectorMap(c);

            c = rotorMap(c, true);

            if (plugBoard.ContainsKey(c))
            {
                c = plugBoard[c];
            }

            return c;
        }

        public void addPlug(char c, char cc)
        {
            if (Char.IsLetter(c) && Char.IsLetter(cc))
            {
                c = Char.ToUpper(c);
                cc = Char.ToUpper(cc);
                if (c != cc && !plugBoard.ContainsKey(c))
                {
                    plugBoard.Add(c, cc);
                    plugBoard.Add(cc, c);
                }
            }
            else
            {
                throw new ArgumentException("Invalid character");
            }
        }
    }
}
