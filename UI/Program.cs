using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Model.Repositories;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Taak1();
            Taak2();

            


            static void Taak1()
            {
                using var context = new EFLandenStedenTalenContext();
                var landen = from land in context.Landen
                             orderby land.Naam
                             select land;
                Console.WriteLine();
                Console.WriteLine("Landen alfabetisch op landnaam");
                Console.WriteLine("==============================");
                Console.WriteLine();
                Console.WriteLine("Landcode - Naam - Inwoners - Oppervlakte");
                Console.WriteLine();
                foreach (var land in landen)
                {
                    Console.WriteLine($"{land.ISOLandCode} - {land.Naam} - {land.AantalInwoners} - {land.Oppervlakte}");
                }
                Console.WriteLine();
            }
            static void Taak2()
            {
                using var context = new EFLandenStedenTalenContext();
                Console.WriteLine();
                Console.WriteLine("Gemeente zoeken met landcode");
                Console.WriteLine("============================");
                Console.WriteLine("Geef een landcode in: ");
                string landCode = Console.ReadLine().ToUpper();
                var gemeenten = from stad in context.Steden
                             where stad.ISOLandCode == landCode
                             select stad;
                foreach (var stad in gemeenten)
                {
                    Console.WriteLine($"{stad.Naam}");
                }
            }
        }        
    }
}
