package com.sykes368.lib.enigma;

import java.util.ArrayList;

/** EnigmaSettings
 * @author Sykes368
 * @since 1.0
 */
class EnigmaSettings {
    private char[] ringSettings;
    private char[] initialPositions;
    private String rotorOrder;
    private char reflector;
    private String[] plugs;

    public EnigmaSettings() {
        setDefaults();
    }

    public char[] getRingSettings() {
        return ringSettings;
    }

    public void setRingSetting(char[] rings) {
        this.ringSettings = rings;
    }

    public char[] getInitialPositions() {
        return initialPositions;
    }

    public void setInitialPositions(char[] initialPositions) {
        this.initialPositions = initialPositions;
    }

    public String getRotorOrder() {
        return rotorOrder;
    }

    public void setRotorOrder(String rOrder) {
        this.rotorOrder = rOrder;
    }

    public char getReflector() {
        return reflector;
    }

    public void setReflector(char reflector) {
        this.reflector = reflector;
    }

    public String[] getPlugs() {
        return plugs;
    }

    public void setPlugs(String[] plugs) {
        this.plugs = plugs;
    }

    public void setDefaults() {
        ringSettings = new char[] {'A', 'A', 'A'};
        initialPositions = new char[] {'A', 'A', 'A'};
        rotorOrder = "I-II-III";
        reflector = 'B';
        plugs = new String[0];
    }
}
