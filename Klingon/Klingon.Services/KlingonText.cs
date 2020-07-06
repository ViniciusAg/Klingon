using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

namespace Klingon.Services
{
    public class KlingonText
    {
        public string GetTextB()
        {
            return RequestWeb("https://raw.githubusercontent.com/f360-dev/provas/master/klingon-textoB.txt");
        }

        public string GetTextA()
        {
            return RequestWeb("https://raw.githubusercontent.com/f360-dev/provas/master/klingon-textoA.txt");
        }

        private static string RequestWeb(string url)
        {
            var requisicaoWeb = WebRequest.CreateHttp(url);
            requisicaoWeb.Method = "GET";
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                return objResponse.ToString();
            }
        }

        public string[] Foo()
        {
            string[] foo = { "f", "k", "l", "s", "w" };
            return foo;
        }

        public string[] Bar()
        {
            string[] bar = { "a", "b", "c", "d", "e", "g", "h", "i", "j", "m", "n", "o", "p", "q", "r", "t", "u", "v", "x", "y", "z" };
            return bar;

        }
    }
}
