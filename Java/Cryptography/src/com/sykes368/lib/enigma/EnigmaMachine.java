package com.sykes368.lib.enigma;

import java.util.HashMap;

/** EnigmaMachine
 * @author Sykes368
 * @since 1.0
 */
class EnigmaMachine {
    // Based on the M3 Army 1938 Enigma Machine

    private final String ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private final String ROTOR_I = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
    private final String ROTOR_II = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
    private final String ROTOR_III = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
    private final String ROTOR_IV = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
    private final String ROTOR_V = "VZBRGITYUPSDNHLXAWMJQOFECK";
    private final String REFLECTOR_A = "EJMZALYXVBWFCRQUONTSPIKHGD";
    private final String REFLECTOR_B = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
    private final String REFLECTOR_C = "FVPJIAOYEDRZXWGCTKUQSBNMHL";

    private Rotor rI = new Rotor(ROTOR_I, 'Q', "I");
    private Rotor rII = new Rotor(ROTOR_II, 'E', "II");
    private Rotor rIII = new Rotor(ROTOR_III, 'V', "III");
    private Rotor rIV = new Rotor(ROTOR_IV, 'J', "IV");
    private Rotor rV = new Rotor(ROTOR_V, 'Z', "V");

    private Rotor[] rotors;
    private Rotor reflector;

    private HashMap<Character, Character> plugBoard;


    class Rotor {
        private int outerPosition;
        private char outerChar;

        // Rotor Alphabet
        private String wiring;

        // Notch turn point
        private char turnPoint;

        private String identifier;

        private char ring;

        private int[] map;

        private int[] revMap;

        Rotor(String wiring, char turnPoint, String identifier)
        {
            this.turnPoint = turnPoint;
            outerPosition = 0;

            ring = 'A';
            this.identifier = identifier;

            map = new int[26];
            revMap = new int[26];

            setWiring(wiring);
        }

        String getIdentifier() {
            return identifier;
        }

        int[] getMap() {
            return map;
        }

        int[] getRevMap() {
            return revMap;
        }

        int getOuterPosition() {
            return outerPosition;
        }

        void setOuterPosition(int outerPosition) {
            this.outerPosition = outerPosition;
            outerChar = ALPHABET.toCharArray()[outerPosition];
        }

        char getOuterChar() {
            return outerChar;
        }

        void setOuterChar(char outerChar) {
            this.outerChar = outerChar;
            outerPosition = ALPHABET.indexOf(outerChar);
        }

        char getRing() {
            return ring;
        }

        void setRing(char ring) {
            this.ring = ring;
        }

        String getWiring() {
            return wiring;
        }

        void setWiring(String wiring)
        {
            this.wiring = wiring;
            outerChar = this.wiring.toCharArray()[outerPosition];

            for (int i = 0; i < 26; i++)
            {
                int match = ((int)this.wiring.toCharArray()[i]) - 65;
                map[i] = (26 + match - i) % 26;
                revMap[match] = (26 + i - match) % 26;
            }
        }

        void step() {
            outerPosition = (outerPosition + 1) % 26;
            outerChar = ALPHABET.toCharArray()[outerPosition];
        }

        boolean isInTurnOver()
        {
            return outerChar == turnPoint;
        }
    }

    public EnigmaMachine()
    {
        plugBoard = new HashMap<>();

        rotors = new Rotor[] { rI, rII, rIII };
        reflector = new Rotor(REFLECTOR_A, ' ', "");
    }

    public void  setReflector(char conf) throws IllegalArgumentException {
        String wiring = switch (conf) {
            case 'A' -> REFLECTOR_A;
            case 'B' -> REFLECTOR_B;
            case 'C' -> REFLECTOR_C;
            default -> throw new IllegalArgumentException("Illegal argument: " + conf);
        };

        reflector.setWiring(wiring);
    }

    public void setSettings(char[] rings, char[] rStart) {
        if (rings.length != rotors.length || rStart.length != rotors.length) {
            throw new IllegalArgumentException("Invalid argument");
        }

        for (int i = 0; i < rotors.length; i++) {
            rotors[i].ring = Character.toUpperCase(rings[i]);
            rotors[i].setOuterChar(Character.toUpperCase(rStart[i]));
        }
    }

    public void setSettings(char[] rings, char[] rStart, String rotorOrder) {
        String[] order = rotorOrder.split("-");

        // Set the order
        for (int i = 0; i < order.length; i++) {
            rotors[i] = switch (order[i]) {
                case "I" -> rI;
                case "II" -> rII;
                case "III" -> rIII;
                case "IV" -> rIV;
                case "V" -> rV;
                default -> throw new IllegalArgumentException("Illegal argument: " + rotorOrder);
            };
        }

        setSettings(rings, rStart);
    }

    public void setSettings(char[] rings, char[] rStart, String rotorOrder, char reflectorConf) {
        setReflector(reflectorConf);
        setSettings(rings, rStart, rotorOrder);
    }

    public void addPlug(char c, char cc) {
        if (Character.isLetter(c) && Character.isLetter(cc))
        {
            c = Character.toUpperCase(c);
            cc = Character.toUpperCase(cc);
            if (c != cc && !plugBoard.containsKey(c))
            {
                plugBoard.put(c, cc);
                plugBoard.put(cc, c);
            }
        }
        else
        {
            throw new IllegalArgumentException("Invalid character");
        }
    }

    private void rotateRotors(Rotor[] r) {
        if (r.length == 3) {
            if (r[1].isInTurnOver()) {
                r[0].step();
                r[1].step();
            } else if (r[2].isInTurnOver()) {
                r[1].step();
            }
            r[2].step();
        }
    }

    private char rotorMap(char c, boolean reverse) {
        int cPos = (int)c - 65;

        if (!reverse) {
            for (int i = rotors.length - 1; i >= 0; i--)
            {
                cPos = rotorValue(rotors[i], cPos, reverse);
            }
        } else {
            for (Rotor rotor : rotors) {
                cPos = rotorValue(rotor, cPos, reverse);
            }
        }

        return ALPHABET.toCharArray()[cPos];
    }

    private int rotorValue(Rotor rotor, int cPos, boolean reverse) {
        int rPos = (int)rotor.ring - 65;
        int d;

        if (!reverse) {
            d = rotor.map[(26 + cPos + rotor.getOuterPosition() - rPos) % 26];
        } else {
            d = rotor.revMap[(26 + cPos + rotor.getOuterPosition() - rPos) % 26];
        }

        return (cPos + d) % 26;
    }

    private char reflectorMap(char c) {
        int cPos = (int)c - 65;
        cPos = (cPos + reflector.map[cPos]) % 26;
        return ALPHABET.toCharArray()[cPos];
    }

    public String runEnigma (String message) {
        StringBuilder messageOut = new StringBuilder();

        char[] msg = message.toUpperCase().toCharArray();

        for (char c: msg) {
            messageOut.append(encryptChar(c));
        }

        return messageOut.toString();
    }

    private char encryptChar(char c) {
        rotateRotors(rotors);

        if (plugBoard.containsKey(c)) {
            c = plugBoard.get(c);
        }

        c = rotorMap(c, false);

        c = reflectorMap(c);

        c = rotorMap(c, true);

        if (plugBoard.containsKey(c)) {
            c = plugBoard.get(c);
        }

        return c;
    }

}
