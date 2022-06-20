using System;
using System.Threading;

namespace app_07
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteARebours compteAReboursA = new(5);

            using(Timer timerA = new ( _ => compteAReboursA.Tic(), null, 0, 1_000 )) 
            {
                compteAReboursA.Fini+=(o, e) => timerA.Change(
                    Timeout.Infinite,
                    Timeout.Infinite
                );
                Thread.Sleep(7_000);
            }

            CompteARebours compteAReboursB = new(5);
            using System.Timers.Timer timerB = new () {
                AutoReset = true,
                Interval = 1_000,
                Enabled = true
            };
            compteAReboursB.Fini += (o, e) => timerB.Stop();
            timerB.Elapsed += (o, e) => compteAReboursB.Tic();
            
            Thread.Sleep(7_000);
        }
    }
}
