using System;

namespace info_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var prix = 3.4m;
            decimal[] bilans = { 12521m, 0m, -7824m, 8m };

            Console.WriteLine($"{prix} / {prix:c} / {prix:'€ '0.00}");
            foreach(var bilan in bilans)
            {
                Console.WriteLine($"{bilan,12:0.00;'!'-0.00;'---'}");
            }
            
            var début = new DateTimeOffset(year: 2021, month: 08, day: 10, hour: 12, 0, 0, offset: TimeSpan.FromHours(1));
            var durée = new TimeSpan(hours: 1, minutes: 30, 0);
            var fin = début + durée;                
            var attente = début - DateTimeOffset.Now;

            Console.WriteLine($"RDV {début:f} - {fin:F} dans {attente:dd\\jhh\\hmm}");            
            Console.WriteLine($"RDV {début:g} - {fin:G} dans {attente:dd\\jhh\\hmm}");            
            Console.WriteLine($"RDV le {début:d} à {début:t} jusqu'à {fin:T} dans {attente:g}");
        }
    }
}
