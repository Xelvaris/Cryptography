package com.sykes368.lib;

/** RailFence Cipher
 * @author Sykes368
 * @since 1.0
 */
public class RailFence {
    public static String encrypt(int rails, String plaintext) {
        if (!plaintext.matches("^[ A-Za-z]+$")) {
            return "ERROR: Input can only be letters and spaces";
        }
        plaintext = plaintext.toUpperCase().replace(" ", "");
        char[][] railChars = new char[rails][plaintext.length()];

        int direction = 1;
        for (int i = 0; i < (plaintext.length()); ) {
            for (int j = 0; j < rails; i++) {
                if (i >= plaintext.length()) break;

                railChars[j][i] = plaintext.charAt(i);

                if (j == 0) direction = 1;
                else if (j == (rails - 1)) direction = 2;

                if (direction == 1) j++;
                else j--;
            }
        }

        char[] output = new char[plaintext.length()];
        for (int j = 0, i = 0; j < rails; j++) {
            for (int c = 0; c < railChars[0].length; c++) {
                if (Character.isLetter(railChars[j][c])) {
                    output[i] = railChars[j][c];
                    i++;
                }
            }
        }
        return new String(output);
    }

    public static String decrypt(int rails, String ciphertext) {
        if (!ciphertext.matches("^[ A-Za-z]+$")) {
            return "ERROR: Input can only be letters and spaces";
        }
        char[][] plainChars = new char[rails][ciphertext.length()];

        int count = 0;
        int cycle = (rails * 2) - 2;
        int a = cycle - 2;
        int b = 2;

        for (int j = 0; j < plainChars.length; j++) {
            int c = 0;
            for (int i = j; i < plainChars[j].length;) {
                if (count != ciphertext.length()) {
                    if (j == 0 || j == rails - 1) {
                        plainChars[j][i] = ciphertext.charAt(count);
                        i = i + cycle;
                    } else {
                        plainChars[j][i] = ciphertext.charAt(count);
                        if (c % 2 == 0)
                            i = i + a;
                        else if (c % 2 == 1)
                            i = i + b;
                        c++;
                    }
                    count++;
                } else
                    break;

            }
            if (j != 0 && j != rails - 1) {
                a = a - 2;
                b = b + 2;
            }
        }
        char[] plaintext = new char[ciphertext.length()];
        for (int c = 0, i = 0; c < plainChars[0].length; c++) {
            for (int j = 0; j < rails; j++) {
                if (c >= ciphertext.length()) break;
                if (Character.isLetter(plainChars[j][c])) {
                    plaintext[i] = plainChars[j][c];
                    i++;
                }
            }
        }
       return new String(plaintext);
    }
}
