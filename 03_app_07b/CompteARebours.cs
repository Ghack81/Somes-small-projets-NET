using System;

namespace app_07
{
    class CompteARebours
    {
        private int valeur;

        public CompteARebours(int init) => valeur = init;
        public bool EstFini => valeur==0;
        public event EventHandler Fini;
        public void Tic()
        {
            if(EstFini)
            {
                throw new InvalidOperationException("Le décompte est terminé !");
            }
            Console.WriteLine(--valeur);
            if(EstFini) 
            {
                Fini?.Invoke(this, EventArgs.Empty);
            }
        }
    }

}