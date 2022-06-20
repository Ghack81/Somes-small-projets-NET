using System;

namespace info_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nombres
            var prix = 3.4m;
            
            Console.WriteLine($"{prix} / {prix:c} / {prix:'€ '0.00}");
            
            // Dates
            var début = new DateTimeOffset(year: 2021, month: 08, day: 10, hour: 12, 0, 0, offset: TimeSpan.FromHours(1));
            var durée = new TimeSpan(hours: 1, minutes: 30, 0);
            var fin = début + durée;                
            var attente = début - DateTimeOffset.Now;
            
            Console.WriteLine($"RDV {début:f} - {fin:F} dans {attente:dd\\jhh\\hmm}");
            Console.WriteLine($"RDV {début:g} - {fin:G} dans {attente:g}"); 
            Console.WriteLine($"RDV le {début:d} à {début:t} jusqu'à {fin:T} dans {attente:G}");var texte0 = "Quel bel ét\u00e9 !";

            // Textes
            var texte1 = "Quel bel ét\u0065\u0301 !";
            var comparaison = texte0.Equals(texte1, StringComparison.Ordinal) ? "identiques" : "différents";
               
            Console.WriteLine($"{texte0} et {texte1} sont {comparaison}");
 
        }
    }
}
