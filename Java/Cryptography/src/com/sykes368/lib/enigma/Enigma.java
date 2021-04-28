package com.sykes368.lib.enigma;

/** Enigma
 * @author Sykes368
 * @since 1.0
 */
public class Enigma {
    public static String Start(String message, String rings, String rotors,
                               String reflector, String plugs, String rotorStart) {

        EnigmaMachine machine = new EnigmaMachine();
        EnigmaSettings eSettings = new EnigmaSettings();

        querySettings(eSettings, rings, rotors, reflector, plugs, rotorStart);

        if (!message.matches("^[a-zA-Z ]+$"))
        {
            return "Error: Only letters A-Z and spaces are allowed";
        }

        message = message.replace(" ", "").toUpperCase();

        machine.setSettings(eSettings.getRingSettings(), eSettings.getInitialPositions(), eSettings.getRotorOrder(), eSettings.getReflector());

        for (String plug: eSettings.getPlugs()) {
            char[] p = plug.toCharArray();
            machine.addPlug(p[0], p[1]);
        }

        return machine.runEnigma(message);
    }

    private static void querySettings(EnigmaSettings eSettings, String ringSettings, String rotorOrder, String reflector,
                                      String plugs, String rotorStartPositions) {

        // Set rings setting (Ex. AAA, MJS, Default: AAA)
        if (ringSettings.equals("")) {
            eSettings.setRingSetting(new char[] {'A', 'A', 'A'});
        } else {
            eSettings.setRingSetting(ringSettings.toCharArray());
        }

        // Set rotor start setting (Ex. AAA, MJS, Default: AAA)
        if (rotorStartPositions.equals("")) {
            eSettings.setInitialPositions(new char[] {'A', 'A', 'A'});
        } else {
            eSettings.setInitialPositions(rotorStartPositions.toCharArray());
        }

        // Set order of rotors (Ex. I-II-III, III-I-IV, V-II-IV Default: I-II-III)
        if (rotorOrder.equals("")) {
            eSettings.setRotorOrder("I-II-III");
        } else {
            eSettings.setRotorOrder(rotorOrder);
        }

        // Set reflector (A, B, or C, Default: B)
        if (reflector.equals("")) {
            eSettings.setReflector('B');
        } else {
            eSettings.setReflector(reflector.charAt(0));
        }

        // Set plugboard configuration (Ex. KH AB CE IJ, Default: None)
        if (!plugs.equals("")) {
            eSettings.setPlugs(plugs.split(" "));
        }
    }
}
