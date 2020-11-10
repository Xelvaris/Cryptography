package com.sykes368.lib;

/** Affine Cipher
 * @author Sykes368
 * @since 1.0
 */
public class Affine implements CiphersAndAlgorithms {
    private final int[] VALID_A = {1,3,5,7,9,11,15,17,19,21,23,25};
    private int a;
    private int b;

    public Affine(int a, int b) {
        this.a = a;
        this.b = b;
    }

    public int getA() {
        return a;
    }

    public int getB() {
        return b;
    }

    public void setA(int a) {
        this.a = a;
    }

    public void setB(int b) {
        this.b = b;
    }

    @Override
    public String encrypt(String plaintext) {
        return affine(plaintext, false);
    }

    @Override
    public String decrypt(String ciphertext) {
        return affine(ciphertext, true);
    }

    private String affine(String input, boolean decode) {
        if (!isAValid(a)) {
            return "ERROR: The value of 'a' is invalid. Valid values are 1,3,5,7,9,11,15,17,19,21,23, and 25.";
        }
        StringBuilder output = new StringBuilder();

        if(!input.matches("^[ A-Za-z]+$")) {
            return "ERROR: Input can only be letters and spaces";
        }
        char[] chars = input.toUpperCase().replace(" ", "").toCharArray();

        for (char c : chars) {
            int x = Character.getNumericValue(c-65);
            if (decode) {
                int aInverse = MultiplicativeInverse(a);
                if (aInverse == -404) {
                    return "ERROR: No Multiplicative Inverse of 'a' Found";
                }
                if (x - b < 0) {
                    x += x + 26;
                }
                output.append((char) (((aInverse * (x - b)) % 26) +65));
            } else {
                output.append((char) (((a * x + b) % 26) + 65));
            }
        }
        return output.toString();
    }

    private  int MultiplicativeInverse(int a) {
        for (int i = 1; i<27; i++) {
            if ((a * i) % 26 == 1) {
                return i;
            }
        }
        return -404;
    }

    private boolean isAValid(int a) {
        for (int vA : VALID_A) {
            if (vA == a) {
                return true;
            }
        }
        return false;
    }
}
