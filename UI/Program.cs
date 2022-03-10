using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Model.Repositories;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Globalization;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetWindowSize(120, 32);
            var DarkMode = ((string)ConsoleHelper.LeesKeuzeUitLijst("Dark Mode", new List<object> { "J", "N", "j", "n" },
            OptionMode.Mandatory)).ToUpper() == "J";
            Console.BackgroundColor = DarkMode ? ConsoleColor.Black : ConsoleColor.White;
            Console.ForegroundColor = DarkMode ? ConsoleColor.White : ConsoleColor.Black;
            Console.Clear();
            string keuze = string.Empty;
            while (keuze.ToUpper() != "X")
            {
                Console.BackgroundColor = DarkMode ? ConsoleColor.Black : ConsoleColor.White;
                Console.ForegroundColor = DarkMode ? ConsoleColor.White : ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("----");
                Console.WriteLine("Menu");
                Console.WriteLine("----");
                Console.WriteLine(" 1. Landen op naam weergeven");
                Console.WriteLine(" 2. Gemeente en talen zoeken met landcode");
                Console.WriteLine(" 3. Aantal inwoners van een land wijzigen");
                Console.WriteLine(" 4. Oppervlakte van een land wijzigen");
                Console.WriteLine(" 5. Gemeente toevoegen aan land");
                Console.WriteLine(" 6. Gemeente verwijderen uit een land");
                
                //Console.WriteLine(" . . . . ");
                // . . . .
                // P l a a t s h i e r d e v e r s c h i l l e n d e m e n u i t e m s
                // . . . .
                keuze = ConsoleHelper.LeesString("Keuze ('X' om te stoppen): ", 2, OptionMode.Mandatory);
                Console.WriteLine("----------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                if (keuze.ToUpper() != "X")
                {
                    // Reflection
                    try
                    {
                        typeof(Program).InvokeMember(("Item" + "00".Substring(0, -keuze.Length + 2)) + keuze
                        , BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.NonPublic
                        , null, null, null);
                    }
                    catch
                    {
                        Console.WriteLine("Ongeldige keuze");
                    }
                }
                // ===
                // End
                // ===
                if (keuze.ToUpper() == "X") break;
                Console.WriteLine("\nDruk een toets");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // ---------
        // Menu-item
        // ---------

        // 1. Landen op naam weergeven
        static void Item01()
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
        // 2. Gemeente en talen zoeken met landcode
        static void Item02()
        {
            using var context = new EFLandenStedenTalenContext();
            Console.WriteLine("Gemeente zoeken met landcode");
            Console.WriteLine("============================");
            Console.WriteLine("Geef een landcode in: ");
            string landCode = Console.ReadLine().ToUpper();
            var gemeenten = from stad in context.Steden
                            where stad.ISOLandCode == landCode
                            select stad;
            if (gemeenten.Count()>0)
            {
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
            else
            {
                Console.WriteLine("Landcode niet gevonden");
            }
        }
        
        // 3. Aantal inwoners land wijzigen
        static void Item03()
        {
            Console.WriteLine("Aantal inwoners wijzigen");
            Console.WriteLine("========================");
            using var context = new EFLandenStedenTalenContext();
            foreach (var land in context.Landen)
            {
                Console.WriteLine($"{land.ISOLandCode}\t{land.Naam}");
            }
            Console.WriteLine("Geef de gekozen landcode in: ");
            string landCode = Console.ReadLine().ToUpper();
            var landKeuze = context.Landen.Where(c => c.ISOLandCode == landCode).FirstOrDefault();            
            if(landKeuze!= null)
            {
                Console.WriteLine("Geef het nieuwe aantal inwoners in: ");
                int nieuwAantalInwoners = Convert.ToInt32(Console.ReadLine());
                landKeuze.AantalInwoners = nieuwAantalInwoners;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Land niet gevonden");
            }            
        }
        // 4. Oppervlakte land wijzigen
        static void Item04()
        {
            Console.WriteLine("Oppervlakte land wijzigen");
            Console.WriteLine("=========================");
            using var context = new EFLandenStedenTalenContext();
            foreach (var land in context.Landen)
            {
                Console.WriteLine($"{land.ISOLandCode}\t{land.Naam}");
            }
            Console.WriteLine("Geef de gekozen landcode in: ");
            string landCode = Console.ReadLine().ToUpper();
            var landKeuze = context.Landen.Where(c => c.ISOLandCode == landCode).FirstOrDefault();            
            if (landKeuze != null)
            {
                Console.WriteLine("Geef de nieuwe oppervlakte in: ");
                float nieuwAantalInwoners = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                landKeuze.Oppervlakte = nieuwAantalInwoners;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Land niet gevonden");
            }
        }
        // 5. Stad aan land toevoegen
        static void Item05()
        {
            Console.WriteLine("Gemeente toevoegen aan een land");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine("Geef een gemeente in: ");
            string nieuweGemeente = Console.ReadLine();
            if(nieuweGemeente != "")
            {
                Console.WriteLine("Kies een land waar je de stad bij wil voegen");
                Console.WriteLine("---------------------------------------------");
                using var context = new EFLandenStedenTalenContext();
                foreach (var landstad in context.Landen)
                {
                    Console.WriteLine($"{landstad.ISOLandCode}\t{landstad.Naam}");
                }
                Console.WriteLine("Geef de landcode in: ");
                string land = Console.ReadLine().ToUpper();
                var nieuweStad = new Stad
                {
                    Naam = nieuweGemeente,
                    ISOLandCode = land
                };
                var landKeuze = context.Landen.Where(c => c.ISOLandCode == land).FirstOrDefault();
                if (landKeuze != null) 
                {
                    var aantalGemeentenMetZelfdeNaam = from gemeente in context.Steden
                                                       where gemeente.ISOLandCode == land && gemeente.Naam == nieuweGemeente
                                                       select gemeente;
                    if (aantalGemeentenMetZelfdeNaam.Count() == 0)
                    {
                        context.Steden.Add(nieuweStad);
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Stad bestaat al in dit land");
                    }                    
                }
                else
                {
                    Console.WriteLine("Ongeldige landkeuze");
                }
            }
            else
            {
                Console.WriteLine("Geen naam ingegeven");
            }
            
            
        }
        // 6. Stad uit land verwijderen
        static void Item06()
        {
            Console.WriteLine("Verwijderen van een stad uit een land");
            Console.WriteLine("=====================================");
            using var context = new EFLandenStedenTalenContext();
            foreach(var land in context.Landen)
            {
                Console.WriteLine($"{land.ISOLandCode}\t{land.Naam}");
            }
            Console.WriteLine("Geef de gekozen landcode in: ");
            string landCode = Console.ReadLine().ToUpper();
            var landKeuze = context.Landen.Where(c => c.ISOLandCode == landCode).FirstOrDefault();
            var stadsIds = new List<object>();
            foreach (var stad in landKeuze.Steden)
            {
                Console.WriteLine($"{stad.StadId}\t{stad.Naam}");
                stadsIds.Add(stad.StadId);
            }
            Console.WriteLine("Geef de gekozen stadsID in: ");
            int stadNr = Convert.ToInt32(Console.ReadLine());
            var teVerwijderenStad = context.Steden.Find(stadNr);
            if (teVerwijderenStad != null)
            {
                if (stadsIds.Contains(teVerwijderenStad.StadId))
                {
                    context.Steden.Remove(teVerwijderenStad);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Foute stadsId");
                }                
            }
            else
            {
                Console.WriteLine("Stad niet gevonden");
            }
        }

    }        
}

