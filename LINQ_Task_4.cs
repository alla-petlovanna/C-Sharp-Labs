using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sites = new List<string>
            {
                "google.com",
                "uk.wikipedia.org",
                "www.youtube.com",
                "metanit.com",
                "context.reverso.net",
                "ukr.net",
                "rezka.ag",
                "languagetool.org",
                "diia.gov.ua",
                "sinoptik.ua"
            };
            var selSites = from i in sites
                           where i.StartsWith("ukr") && i.EndsWith(".net")
                           select i;
            foreach (string str in selSites) Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
