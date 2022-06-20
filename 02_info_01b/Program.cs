using System;

namespace info_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = @"pique 
                cœur
                trèfle
                carreau";
            

            
            var text = "Nombres";
            var sep = " : ";

            for(var i=1; i<=7; i++) {
                text += $"{sep}{i}";
                sep=", ";
            }
            Console.WriteLine(text);
            text = text.Insert(7, " de 1 à 7");
            Console.WriteLine(text);
        }
    }
}
