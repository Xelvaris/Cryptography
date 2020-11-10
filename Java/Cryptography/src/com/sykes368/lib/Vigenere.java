package com.sykes368.lib;

/** Vigenere Cipher
 * @author Sykes368
 * @since 1.0
 */
public class Vigenere implements CiphersAndAlgorithms {
    private String keyword;

    public Vigenere(String keyword) {
        this.keyword = keyword.toUpperCase().replace(" ", "");
    }

    public String getKeyword() {
        return keyword;
    }

    public void setKeyword(String keyword) {
        this.keyword = keyword.toUpperCase().replace(" ", "");
    }

    @Override
    public String encrypt(String plaintext) {
       return vigenere(plaintext, false);
    }

    @Override
    public String decrypt(String ciphertext) {
       return vigenere(ciphertext, true);
    }

    private String vigenere(String input, boolean decode) {
        if (keyword == null) {
            return "Error: You must enter a keyword";
        }
        for (int i = 0; i < keyword.length(); ++i) {
            if (!Character.isLetter(keyword.charAt(i))) {
                return "Error: Non-letter character entered in keyword";
            }
        }
        if (input == null || !input.matches("^[ A-Za-z]+$")) {
            return "ERROR: Input cannot be empty and Only letters and spaces are allowed as input";
        }

        input = input.toUpperCase().replace(" ", "");
        String key = generateKey(input, keyword);
        StringBuilder output = new StringBuilder();

        for (int i = 0 ; i < input.length(); i++)
        {
            int x;
            if (decode) {
                x = (input.charAt(i) - key.charAt(i) + 26) %26;
            } else {
                x = (input.charAt(i) + key.charAt(i)) %26;
            }

            x += 'A';
            output.append((char) (x));
        }
        return output.toString();
    }

    private static String generateKey(String input, String key)
    {
        int x = input.length();

        StringBuilder keyBuilder = new StringBuilder(key);
        for (int i = 0; ; i++) {
            if (x == i) {
                i = 0;
            }
            if (keyBuilder.length() == input.length()) {
                break;
            }
            keyBuilder.append(keyBuilder.charAt(i));
        }
        key = keyBuilder.toString();
        return key;
    }
}
