package com.sykes368.lib;

/** Caesar Cipher
 * @author Sykes368
 * @since 1.0
 */
public class Caesar {
    public static String encrypt(int shift, String plaintext) {
        return caesar(plaintext, shift, false);
    }

    public static String decrypt(int shift, String ciphertext) {
        return caesar(ciphertext, shift, true);
    }

    private static String caesar(String input, int shift, boolean decode) {
        if (input == null || !input.matches("^[ A-Za-z]+$")) {
            return "ERROR: Input cannot be empty and only letters and spaces are allowed as input";
        }

        char[] buffer = input.replace(" ", "").toUpperCase().toCharArray();

        for (int i = 0; i < buffer.length; i++) {
            char letter = buffer[i];
            if(decode) {
                letter = (char) (letter - shift);
            } else {
                letter = (char) (letter + shift);
            }
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