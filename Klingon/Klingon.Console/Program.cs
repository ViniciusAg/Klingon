using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Klingon.Services;
namespace RequisicoesWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            //var textB = new KlingonText();
            //string[] letters = textB.GetTextB().Split(" ");

            var countPreositons = new Prepositions();

            countPreositons.CountPrepositions();

        }
    }
}