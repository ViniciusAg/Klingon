using System;
using System.Collections.Generic;
using System.Text;

namespace Klingon.Services
{
    public class Alphabet
    {
        public Dictionary<char, int> OrderedAlphabet()
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int> {
                { 'k', 0 },
                { 'b', 1 },
                { 'w', 2 },
                { 'r', 3 },
                { 'q', 4 },
                { 'd', 5 },
                { 'n', 6 },
                { 'f', 7 },
                { 'x', 8 },
                { 'j', 9 },
                { 'm', 10 },
                { 'l', 11 },
                { 'v', 12 },
                { 'h', 13 },
                { 't', 14 },
                { 'c', 15 },
                { 'g', 16 },
                { 'z', 17 },
                { 'p', 18 },
                { 's', 19 } 
            };
            return alphabet;
        }
    }
}
