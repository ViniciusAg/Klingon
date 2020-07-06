using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klingon.Services
{
    public class Verbs
    {
        public KlingonText _text = new KlingonText();
        

        private string[] VerbsTextB()
        {
            string[] words = _text.GetTextB().Split(" ");
            string[] verbs = words.Where(x => x.Length == 8 && _text.Foo()
                                               .Contains(x.Substring(x.Length - 1, 1)))
                                               .ToArray();
            return verbs;
        }
        public int CountVerbs()
        {
            return VerbsTextB().Length;
        }
        public int FirtsPersonVerbs()
        {
            return VerbsTextB().Where(x => _text.Bar()
                               .Contains(x.Substring(0, 1)))
                               .ToArray()
                               .Length;
        }
    }
}
