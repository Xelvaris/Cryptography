using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CryptoEnigma
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
}
