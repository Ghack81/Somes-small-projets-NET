using System;

namespace info_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime début = new (year: 2021, month: 08, day: 10, hour: 12, 0, 0);
            TimeSpan durée = new (hours: 1, minutes: 30, 0);
            var fin = début + durée;                
            var attente = début - DateTime.Now;

            Console.WriteLine($"RDV {début} à {fin} dans {attente}");
        }
    }
}
