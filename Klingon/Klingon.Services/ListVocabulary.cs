using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klingon.Services
{
    public class ListVocabulary
    {
        private KlingonText _text = new KlingonText();

        public string OrderedTextB()
        {
            string[] words = _text.GetTextB().Split(" ");
            var _alphabet = new Alphabet();

            List<string> orderWords = words.OrderBy(x => _alphabet.OrderedAlphabet()[Convert.ToChar(x.Substring(0, 1))])
                                           .ThenBy(x => _alphabet.OrderedAlphabet()[Convert.ToChar(x.Substring(1, 1))])
                                           .ThenBy(x => _alphabet.OrderedAlphabet()[Convert.ToChar(x.Substring(2, 1))])
                                           .Distinct()
                                           .ToList();

            return string.Join(" ", orderWords);
        }



    }
}
