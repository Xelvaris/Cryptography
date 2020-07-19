package com.sykes368.lib;

public class Caesar {

    public String encrypt(String input, int shift) {
        if (!input.matches("^[ A-Za-z]+$")) {
            return "ERROR: Only letters and spaces are allowed as input";
        }

        char[] buffer = input.replace(" ", "").toUpperCase().toCharArray();

        for (int i = 0; i < buffer.length; i++) {
            char letter = buffer[i];
            letter = (char) (letter + shift);
            if (letter > 'Z') {
                letter = (char) (letter - 26);
            } else if (letter < 'A') {
                letter = (char) (letter + 26);
            }
            buffer[i] = letter;
        }
        return new String(buffer);
    }

    public String decrypt(String input, int shift) {
        if (!input.matches("^[ A-Za-z]+$")) {
            return "ERROR: Only letters and spaces are allowed as input";
        }

        char[] buffer = input.replace(" ", "").toUpperCase().toCharArray();

        for (int i = 0; i < buffer.length; i++) {
            char letter = buffer[i];
            letter = (char) (letter - shift);
            if (letter > 'Z') {
                letter = (char) (letter - 26);
            } else if (letter < 'A') {
                letter = (char) (letter + 26);
            }
            buffer[i] = letter;
        }
        return new String(buffer);
    }
}