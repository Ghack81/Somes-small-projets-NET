using System;

namespace info_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset début = new (year: 2021, month: 08, day: 10, hour: 12, 0, 0, offset: TimeSpan.FromHours(1));
            TimeSpan durée = new (hours: 1, minutes: 30, 0);
            var fin = début + durée;                
            var attente = début - DateTime.Now;         

            Console.WriteLine($"RDV {début} à {fin} dans {attente}");
        }
    }
}
