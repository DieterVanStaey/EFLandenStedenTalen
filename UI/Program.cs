using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Model.Repositories;
using Microsoft.EntityFrameworkCore;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedingLandTaal();
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
                var land = context.Landen.Where(c => c.ISOLandCode == "BE").FirstOrDefault();
                foreach (var taal in land.Talen)
                {
                    Console.WriteLine($"{taal.NaamNL}");
                }
            }
            static void SeedingLandTaal()
            {
                using var context = new EFLandenStedenTalenContext();
                var landBE = context.Landen.Where(c => c.ISOLandCode == "BE").FirstOrDefault();
                var landDE = context.Landen.Where(c => c.ISOLandCode == "DE").FirstOrDefault();
                var landLU = context.Landen.Where(c => c.ISOLandCode == "LU").FirstOrDefault();
                var landFR = context.Landen.Where(c => c.ISOLandCode == "FR").FirstOrDefault();
                var landNL = context.Landen.Where(c => c.ISOLandCode == "NL").FirstOrDefault();

                var taalNl = context.Talen.Where(t => t.ISOTaalCode == "nl").FirstOrDefault();
                var taalDe = context.Talen.Where(t => t.ISOTaalCode == "de").FirstOrDefault();
                var taalFr = context.Talen.Where(t => t.ISOTaalCode == "fr").FirstOrDefault();

                landBE.Talen.Add(taalNl);
                landBE.Talen.Add(taalFr);
                landBE.Talen.Add(taalDe);
                landLU.Talen.Add(taalFr);
                landLU.Talen.Add(taalDe);
                landDE.Talen.Add(taalDe);
                landFR.Talen.Add(taalFr);
                landNL.Talen.Add(taalNl);

                context.SaveChanges();
                
            }
        }        
    }
}
