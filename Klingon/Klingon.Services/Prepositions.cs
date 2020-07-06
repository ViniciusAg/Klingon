using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Linq;

namespace Klingon.Services
{
    public class Prepositions
    {
        private KlingonText _text = new KlingonText();
        
        public int CountPrepositions()
        {
            string[] words = _text.GetTextB().Split(" ");

            string[] prepositions = words.Where(x => x.Length == 3 && _text.Bar()
                                           .Contains(x.Substring(x.Length - 1, 1)) && !x
                                           .Contains("d"))
                                           .ToArray();

           return prepositions.Length;

        }

    }
}
