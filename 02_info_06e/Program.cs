using System;

namespace info_06
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, bool, string) tuple = (3, true, "texte");

            tuple.Item1 = 2;
            var tuple2 = tuple;

            var (a, b, c) = tuple;

            var tuple3 = (entier: 2, booléen: true, chaine: "texte");

            if(tuple3 == tuple) {
                Console.WriteLine("égaux");
            }
        }
    }
}
