using System;
using System.Threading;

namespace app_07
{
    class Program
    {
        CompteARebours compteAReboursA = new(5);

        // compteAReboursA.Fini += (o, e) => Console.WriteLine("Compte à rebours terminé");
                    
        compteAReboursA.Tic(); Thread.Sleep(1_000);
        compteAReboursA.Tic(); Thread.Sleep(1_000);
        compteAReboursA.Tic(); Thread.Sleep(1_000);
        compteAReboursA.Tic(); Thread.Sleep(1_000);
        compteAReboursA.Tic(); 
    }
}
