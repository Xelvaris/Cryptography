package com.sykes368.lib;

import java.util.ArrayList;

/** PlayFair Cipher
 * @author Sykes368
 * @since 1.0
 */
public class PlayFair {
    private static final int ROW_INDEX = 0;
    private static final int COL_INDEX = 1;

    public static String encrypt(String keyword, String plaintext) {
        return playFair(keyword, plaintext, false);
    }

    public static String decrypt(String keyword, String ciphertext) {
        return playFair(keyword, ciphertext, true);
    }

    private static String playFair(String keyword, String input, boolean decode) {
        if (!input.matches("^[ A-Za-z]+$")) {
            return "ERROR: Input can only be letters and spaces";
        }

        StringBuilder output = new StringBuilder();

        String[] inputText;

        if (decode) {
            inputText = splitText(input);
        } else {
            inputText = formatInput(input);
        }

        char[][] keySquare = generateKeySquare(keyword);

        for (String s: inputText) {
            char c1 = s.charAt(0);
            char c2 = s.charAt(1);

            int[] c1Location = locateChar(c1, keySquare);
            int[] c2Location = locateChar(c2, keySquare);

            int rowC1 = c1Location[ROW_INDEX];
            int colC1 = c1Location[COL_INDEX];
            int rowC2 = c2Location[ROW_INDEX];
            int colC2 = c2Location[COL_INDEX];


            if (rowC1 == rowC2) {
                if (decode) {
                    colC1 = numSub1(colC1);
                    colC2 = numSub1(colC2);

                    output.append(keySquare[rowC1][colC1]);
                    output.append(keySquare[rowC2][colC2]);
                } else {
                    output.append(keySquare[rowC1][(colC1 + 1) % 5]);
                    output.append(keySquare[rowC2][(colC2 + 1) % 5]);
                }
            } else if (colC1 == colC2) {
                if (decode) {
                    output.append(keySquare[(rowC1 + 1) % 5][colC1]);
                    output.append(keySquare[(rowC2 + 1) % 5][colC2]);
                } else {
                    rowC1 = numSub1(rowC1);
                    rowC2 = numSub1(rowC2);

                    output.append(keySquare[rowC1][colC1]);
                    output.append(keySquare[rowC2][colC2]);
                }
            } else {
                output.append(keySquare[rowC1][colC2]);
                output.append(keySquare[rowC2][colC1]);
            }
        }

        return output.toString();
    }

    private static int numSub1(int in) {
        int out = in - 1;

        if (out < 0) {
            out += 5;
        }

        return out;
    }

    private static int[] locateChar(char c, char[][] keySquare) {
        int[] output = new int[2];

        for (int row = 0; row < keySquare.length; row++) {
            for (int col = 0; col < keySquare[0].length; col++) {
                if (c == keySquare[row][col]) {
                    output[ROW_INDEX] = row;
                    output[COL_INDEX] = col;
                    break;
                }
            }
        }

        return output;
    }

    private static String[] formatInput(String input) {
        input = input.toUpperCase().replace('J', 'I').replace(" ", "");

        StringBuilder formattedInput = new StringBuilder();

        for (int i = 0; i < input.length(); i++) {
            char c = input.charAt(i);

            if(formattedInput.length() < 1) {
                formattedInput.append(c);
                continue;
            }

            if(c == formattedInput.toString().charAt(formattedInput.length() - 1)) {
                formattedInput.append('X');
            }
            formattedInput.append(c);
        }

        if (formattedInput.length() % 2 != 0) {
            formattedInput.append('X');
        }

        return splitText(formattedInput.toString());
    }

    private static String[] splitText(String fInput) {
        ArrayList<String> output = new ArrayList<>();

        for(int i = 0; i < fInput.length() - 1; i += 2) {
            String temp = "" + fInput.charAt(i) + fInput.charAt(i + 1);
            output.add(temp);
        }

        return output.toArray(new String[0]);
    }

    private static char[][] generateKeySquare(String keyword) {
        String alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        for (char k: keyword.toUpperCase().toCharArray()) {
            alphabet = alphabet.replace(k, ' ').replace(" ", "");
        }

        String key_w_alpha = keyword.toUpperCase().replace(" ", "") + alphabet;
        char[] kwa = key_w_alpha.toCharArray();
        char[][] keySquare = new char[5][5];

        int pos = 0;
        for(int row = 0; row < 5; row++) {
            for (int col = 0; col < 5; col++, pos++) {
                keySquare[row][col] = kwa[pos];
            }
        }

        return keySquare;
    }

}