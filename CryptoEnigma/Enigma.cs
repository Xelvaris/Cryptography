using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoEnigma
{
    public class Enigma
    {
        //Based around Enigma M3 Army 1938

        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string rotorI = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
        private const string rotorII = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
        private const string rotorIII = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
        private const string rotorIV = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
        private const string rotorV = "VZBRGITYUPSDNHLXAWMJQOFECK";
        private const string reflectorA = "EJMZALYXVBWFCRQUONTSPIKHGD";
        private const string reflectorB = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
        private const string reflectorC = "FVPJIAOYEDRZXWGCTKUQSBNMHL";

        private RotorsReflector[] rotors;
        private RotorsReflector reflector;

        private Dictionary<Char, Char> plugBoard;
    }
}
