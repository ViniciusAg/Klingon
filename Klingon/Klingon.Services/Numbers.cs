using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Klingon.Services
{
    public class Numbers
    {
        private readonly KlingonText _text = new KlingonText();
        
        public int DistinctBeautifulNumbers()
        {
            string[] words = _text.GetTextB().Split(" ");
            var _alphabet = new Alphabet();
            List<long> total = new List<long>();
            

            foreach (var word in words)
            {
                long result = 0;
                long increment = 1;
                foreach (var character in word)
                {
                    var resultChar = _alphabet.OrderedAlphabet().GetValueOrDefault(character);
                    
                    result += increment * resultChar;
                    increment *= 20;
                }

                if (result >= 440566 && result % 3 == 0)
                {

                    total.Add(result);
                }
            }

            return total.Count();
        }

    }
}
