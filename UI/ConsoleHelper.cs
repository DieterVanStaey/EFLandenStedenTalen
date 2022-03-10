using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UI
{
    public enum OptionMode
    {
        Optional = 0,
        Mandatory = 1
    }
    public enum SelectionMode
    {
        Single = 0,
        Multiple = 1,
        None = 2
    }
    public static class ConsoleHelper
    {
        private const int LengthInputLabel = 32;
        public static string LeesString(string label, int maxLength, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            while (!ok)
            {
                Console.Write($"{label + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                else if (input.Length > maxLength)
                {
                    ToonFoutBoodschap($"De ingave is te lang (max {maxLength} tekens)...");
                    continue;
                }
                ok = true;
            }
            return input;
        }
        public static DateTime? LeesDatum(string label, DateTime MinDate, DateTime MaxDate, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            DateTime datumParse;
            int maxLength = 10;
            while (!ok)
            {
                Console.Write($"{label + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                if (input.Length > maxLength)
                {
                    ToonFoutBoodschap($"De ingave is te lang (max {maxLength} tekens)...");
                    continue;
                }
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (!DateTime.TryParse(input, out datumParse))
                    {
                        ToonFoutBoodschap("Ongeldige Datum...");
                        continue;
                    }
                    if (datumParse < MinDate || datumParse > MaxDate)
                    {
                        ToonFoutBoodschap($"De datum moet liggen tussen {MinDate} en {MaxDate}...");
                        continue;
                    }
                }
                ok = true;
            }
            if (string.IsNullOrWhiteSpace(input))
                return null;
            else
            {
                DateTime datum;
                DateTime.TryParse(input, out datum);
                return datum;
            }
        }
        public static int? LeesInt(string label, int Min, int Max, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            int intParse;
            while (!ok)
            {
                Console.Write($"{label + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (!int.TryParse(input, out intParse))
                    {
                        ToonFoutBoodschap("Ongeldig getal...");
                        continue;
                    }
                    if (intParse < Min || intParse > Max)
                    {
                        ToonFoutBoodschap($"Het getal moet liggen tussen {Min} en {Max}...");
                        continue;
                    }
                }
                ok = true;
            }
            if (string.IsNullOrWhiteSpace(input))
                return null;
            else
            {
                //int intInput;
                int.TryParse(input, out intParse);
                return intParse;
            }
        }
        public static decimal? LeesDecimal(string label, decimal Min, decimal Max, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            decimal decimalParse;
            while (!ok)
            {
                Console.Write($"{label + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (!decimal.TryParse(input, out decimalParse))
                    {
                        ToonFoutBoodschap("Ongeldig getal...");
                        continue;
                    }
                    if (decimalParse < Min || decimalParse > Max)
                    {
                        ToonFoutBoodschap($"Het getal moet liggen tussen {Min} en {Max}...");
                        continue;
                    }
                }
                ok = true;
            }
            if (string.IsNullOrWhiteSpace(input))
                return null;
            else
            {
                decimal.TryParse(input, out decimalParse);
                return decimalParse;
            }
        }
        public static float? LeesFloat(string label, float Min, float Max, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            float floatParse;
            while (!ok)
            {
                Console.Write($"{label + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (!float.TryParse(input, out floatParse))
                    {
                        ToonFoutBoodschap("Ongeldig getal...");
                        continue;
                    }
                    if (floatParse < Min || floatParse > Max)
                    {
                        ToonFoutBoodschap($"Het getal moet liggen tussen {Min} en {Max}...");
                        continue;
                    }
                }
                ok = true;
            }
            if (string.IsNullOrWhiteSpace(input))
                return null;
            else
            {
                float.TryParse(input, out floatParse);
                return floatParse;
            }
        }
        public static bool? LeesBool(string label, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            bool inputReturn = false;
            int maxLength = 1;
            while (!ok)
            {
                Console.Write($"{label + " Y/N" + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                if (input.Length > maxLength)
                {
                    ToonFoutBoodschap($"De ingave is te lang (max {maxLength} tekens)...");
                    continue;
                }
                if (!(input.ToUpper() == "Y" || input.ToUpper() == "N"))
                {
                    ToonFoutBoodschap("Ongeldige keuze (Y/N)...");
                    continue;
                }
                if (input.ToUpper() == "Y") inputReturn = true;
                else inputReturn = false;
                ok = true;
            }
            return inputReturn;
        }
        public static List<Object> LeesLijst(string titel, IEnumerable<object> l, List<string> DisplayValues, SelectionMode selectionMode, OptionMode
        optionMode)
        {
            var lijst = l;
            ToonTitel($"{titel}{(selectionMode == SelectionMode.Multiple ? " (gescheiden door een comma)" : "")}", optionMode);
            List<Object> gekozenObjecten = new List<Object>();
            var ok = false;
            while (!ok)
            {
#nullable enable
                string? seqKeuzes;
#nullable disable
                int intKeuze;
                int seq = 0;
                foreach (var displayValue in DisplayValues) Console.WriteLine($"{++seq}\t{displayValue}");
                // Multiple selection
                if (selectionMode == SelectionMode.Multiple)
                {
                    seqKeuzes = LeesString("Geef het volgnummer uit de lijst", 1000, OptionMode.Optional);
                    if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(seqKeuzes))
                    {
                        ToonFoutBoodschap("De keuze is verplicht.");
                        continue;
                    }
                    if (optionMode == OptionMode.Optional && string.IsNullOrWhiteSpace(seqKeuzes)) break;
                    string[] keuzes = seqKeuzes.Split(',');
                    var okLijst = true;
                    gekozenObjecten.Clear();
                    // Validate
                    foreach (var keuze in keuzes)
                    {
                        if (int.TryParse(keuze, out intKeuze))
                        {
                            if (intKeuze > 0 & intKeuze <= seq)
                                gekozenObjecten.Add(lijst.ElementAt(intKeuze - 1));
                            else
                            {
                                ToonFoutBoodschap($"Ongeldige keuze. Keuze tussen 1 en {seq}. Probeer opnieuw...");
                                okLijst = false;
                                break;
                            }
                        }
                        else
                        {
                            ToonFoutBoodschap("De lijst mag enkel cijfers bevatten...");
                            okLijst = false;
                            break;
                        }
                    }
                    if (okLijst) ok = true;
                }
                // Single Selection
                if (selectionMode == SelectionMode.Single)
                {
                    int? leesInt = LeesInt("Geef het volgnummer uit de lijst", 1, seq, OptionMode.Optional);
                    intKeuze = leesInt == null ? 0 : (int)leesInt;
                    if (intKeuze == 0 && optionMode == OptionMode.Mandatory)
                    {
                        ToonFoutBoodschap("De keuze is verplicht.");
                        continue;
                    }
                    if (intKeuze > 0) gekozenObjecten.Add(lijst.ElementAt((int)intKeuze - 1));
                    ok = true;
                }
                // No Selection (display only)
                if (selectionMode == SelectionMode.None)
                    ok = true;
            }
            Console.WriteLine();
            return gekozenObjecten;
        }
        public static object LeesKeuzeUitLijst(string label, List<object> keuzeLijst, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            string keuzes = string.Join(", ", keuzeLijst);
            keuzes = " (" + keuzes + ")";
            while (!ok)
            {
                Console.Write($"{label + keuzes + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                else if (!keuzeLijst.Contains(input))
                {
                    ToonFoutBoodschap("Verkeerde keuze...");
                    continue;
                }
                ok = true;
            }
            if (!string.IsNullOrWhiteSpace(input))
                return keuzeLijst.ElementAt(keuzeLijst.IndexOf(input));
            else
                return null;
        }
        public static string LeesTelefoonNummer(string label, OptionMode optionMode)
        {
            return LeesRegex(label, new Regex(@"^((\+|00(\s|\s?\-\s?)?)32(\s|\s?\-\s?)?(\(0\)[\-\s]?)?|0)[1-9]((\s|\s?\-\s?)?[0-9])((\s|\s?-\s?)?[0-
9])((\s|\s?-\s?)?[0-9])\s?[0-9]\s?[0-9]\s?[0-9]\s?[0-9]\s?[0-9]$"), optionMode);
        }
        public static string LeesEmailAdres(string label, OptionMode optionMode)
        {
            return LeesRegex(label, new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"), optionMode);
        }
        public static string LeesWebsiteUrl(string label, OptionMode optionMode)
        {
            return LeesRegex(label, new Regex(@"(?<Protocol>\w+):\/\/(?<Domain>[\w@][\w.:@]+)\/?[\w\.?=%&=\-@/$,]*"), optionMode);
        }
        public static string LeesRegex(string label, Regex regex, OptionMode optionMode)
        {
            var ok = false;
#nullable enable
            string? input = null;
#nullable disable
            while (!ok)
            {
                Console.Write($"{label + (optionMode == OptionMode.Mandatory ? "* : " : " : "),LengthInputLabel}");
                input = Console.ReadLine();
                if (optionMode == OptionMode.Mandatory && string.IsNullOrWhiteSpace(input))
                {
                    ToonFoutBoodschap("Verplichte ingave...");
                    continue;
                }
                else if (optionMode == OptionMode.Mandatory && !regex.Match(input).Success)
                {
                    ToonFoutBoodschap("Verkeerd formaat...");
                    continue;
                }
                ok = true;
            }
            return input;
        }
        public static string LeesPaswoord(string label, int minlengte, int maxLengte, OptionMode optionMode)
        {
            bool ok = false;
            var paswoord = "";
            while (!ok)
            {
                paswoord = LeesString(label, maxLengte, optionMode);
                if ((optionMode == OptionMode.Mandatory) || (optionMode == OptionMode.Optional && paswoord.Length > 0))
                {
                    // Minimum eight characters, one uppercase letter, one lowercase letter, one number and one special character:
                    Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&_])[A-Za-z\d@$!%*?&_]{" + minlengte + "," + maxLengte +
                    "}$");
                    if (regex.IsMatch(paswoord))
                    {
                        if (paswoord != LeesString("Wachtwoord bevestigen", maxLengte, optionMode))
                            ToonFoutBoodschap("Wachtwoord en Wachtwoordbevestiging moeten gelijk zijn.");
                        else
                            ok = true;
                    }
                    else
                        ToonFoutBoodschap($"Het paswoord moet minsens 1 kleine letter, 1 hoofdletter, 1 cijfer bevatten en één speciaal teken.\nHet paswoord moet minstens { minlengte} tekens lang zijn.");
                }
                else
                    ok = true;
            }
            //Console.Write(new string('\b', paswoord.Length) + new string('*', paswoord.Length));
            return paswoord;
        }
        public static void ToonBoodschap(string tekst, ConsoleColor tekstkleur)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = tekstkleur;
            Console.WriteLine(tekst);
            Console.ForegroundColor = color;
        }
        public static void ToonFoutBoodschap(string tekst)
        {
            ToonBoodschap(tekst, ConsoleColor.Red);
        }
        public static void ToonInfoBoodschap(string tekst)
        {
            ToonBoodschap(tekst, ConsoleColor.DarkGreen);
        }
        public static void ToonTitel(string titel, OptionMode optionMode)
        {
            Console.WriteLine($"\n{titel + (optionMode == OptionMode.Mandatory ? "*" : "")}");
        }
    }
}
