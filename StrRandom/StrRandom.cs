using System;
using System.Collections.Generic;
using System.Text;

namespace StrRandom
{
    public class StrRandom
    {
        private readonly Random _random = new Random();

        public const string Alphabet =
            "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public string GenerateString(int size = 8)
        {
            var chars = new char[size];

            for (var i = 0; i < size; i++)
            {
                chars[i] = Alphabet[_random.Next(Alphabet.Length)];
            }

            return new string(chars);
        }
    }
}
