using System;
using System.Collections.Generic;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var decryptions = new Dictionary<char, char>
            {
                { '!', '1' },
                { '@', '2' },
                { '#', '3' },
                { '$', '4' },
                { '%', '5' },
                { '^', '6' },
                { '&', '7' },
                { '*', '8' },
                { '(', '9' },
                { ')', '0' }
            };

            foreach (var symbols in cryptedNumbers)
            {
                var value = "";

                foreach (var symbol in symbols)
                {
                    if (decryptions.ContainsKey(symbol))
                    {
                        value += decryptions[symbol];
                    }
                    else
                    {
                        value += symbol;
                    }
                }

                Console.WriteLine(value);
            }
        }
    }
}
