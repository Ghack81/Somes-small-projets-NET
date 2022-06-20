using System;
using System.Collections.Generic;

namespace info_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var début = new DateTimeOffset(year: 2021, month: 08, day: 10, hour: 12, 0, 0, offset: TimeSpan.FromHours(1));
            var durée = new TimeSpan(hours: 1, minutes: 30, 0);
            var fin = début + durée;
            var attente = début - DateTimeOffset.Now;

            Console.WriteLine($"RDV {début:f} - {fin:F} dans {attente:dd\\jhh\\hmm}");
            Console.WriteLine($"RDV {début:g} - {fin:G} dans {attente:g}"); // DateTime : s
            Console.WriteLine($"RDV le {début:d} à {début:t} jusqu'à {fin:T} dans {attente:G}"); 
        }
    }
}
