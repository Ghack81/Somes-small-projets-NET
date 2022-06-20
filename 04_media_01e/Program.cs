using System;
using System.Resources;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Threading;

namespace media_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var img = Assembly.GetExecutingAssembly().GetManifestResourceStream("chat");

            using(FileStream fichier = new ("chat2.jpeg", FileMode.Create)) 
            {
                img.CopyTo(fichier);
            }
            var culture = CultureInfo.CreateSpecificCulture("fr-FR");
            
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            
            var res = new ResourceManager("strings", Assembly.GetExecutingAssembly());

            Console.WriteLine(res.GetString("hello"));
            Console.WriteLine(res.GetString("bye"));
        }
    }
}
