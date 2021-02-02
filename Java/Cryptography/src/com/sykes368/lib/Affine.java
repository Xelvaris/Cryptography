package com.sykes368.lib;

import java.math.BigInteger;

/** Affine Cipher
 * @author Sykes368
 * @since 1.0
 */
public class Affine {
    private static final int[] VALID_A = {1,3,5,7,9,11,15,17,19,21,23,25};

    public static String encrypt(int a, int b, String plaintext) {
        return affine(plaintext, a, b, false);
    }

    public static String decrypt(int a, int b, String ciphertext) {
        return affine(ciphertext, a, b, true);
    }

    private static String affine(String input, int a, int b, boolean decode) {
        if (!isAValid(a)) {
            return "ERROR: The value of 'a' is invalid. Valid values are 1,3,5,7,9,11,15,17,19,21,23, and 25.";
        }
        if(!input.matches("^[ A-Za-z]+$")) {
            return "ERROR: Input can only be letters and spaces";
        }


        StringBuilder output = new StringBuilder();
        char[] chars = input.toUpperCase().replace(" ", "").toCharArray();

        for (char c : chars) {
            if (decode) {
                int aInverse = BigInteger.valueOf(a).modInverse(BigInteger.valueOf(26)).intValue();
                output.append((char) ((aInverse * (c - 'A' - b + 26)) % 26 + 'A'));
            } else {
                output.append((char) ((a * (c - 'A') + b) % 26 + 'A'));
            }
        }
        return output.toString();
    }

    private static boolean isAValid(int a) {
        for (int vA : VALID_A) {
            if (vA == a) {
                return true;
            }
        }
        return false;
    }
}
