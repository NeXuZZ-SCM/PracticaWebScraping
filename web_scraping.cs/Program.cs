using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace web_scraping.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = @"https://thehackernews.com/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var cualquiera = htmlDoc.DocumentNode.SelectSingleNode("//h2[@class='home-title']").InnerText;

            Console.WriteLine("Tomando el primer titulo:\n" + cualquiera);
            Console.WriteLine("\n\n\nObteniendo la lista de titulos:");
            var cualesquiera = htmlDoc.DocumentNode.SelectNodes("//h2[@class='home-title']");
            int i=0;
            foreach(var item in cualesquiera)
            {
                Console.WriteLine($"Titulo {i+1}: " + cualesquiera[i].InnerText);
                i++;
            }
            Console.Read();
        }
    }
}
