using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace app_02
{
    // dotnet add package System.Configuration.ConfigurationManager
    class Program
    {
        public record Pays(string Nom, decimal Superficie);
        public record Ville(string Nom, int Population, Pays Pays);
        static void Main(string[] args)
        {
            var conf = ConfigurationManager.AppSettings;  

            Console.WriteLine(ConfigurationManager.AppSettings["accueil"]);
            if(!int.TryParse(conf["top"], out int top)) {
                top = 5;
            }
            var infosPays = ConfigurationManager.GetSection("infos/pays") as Hashtable;
            var listePays = infosPays
                .Cast<DictionaryEntry>()
                .Select(paire => new Pays(
                    paire.Key.ToString(), 
                    decimal.Parse(paire.Value.ToString())
                ));

            var pays = listePays.ToDictionary(p => p.Nom);
            var villes = new List<Ville> {
                new Ville("Athènes"          ,  3495000, pays["Grèce"] ),
                new Ville("Barcelone"        ,  4849691, pays["Espagne"] ),
                new Ville("Berlin"           ,  4666175, pays["Allemagne"] ),
                new Ville("Birmingham"       ,  2570000, pays["Royaume-Uni"] ),
                new Ville("Bruxelles"        ,  2050000, pays["Belgique"] ),
                new Ville("Kiev"             ,  2957000, pays["Ukraine"] ),
                new Ville("Lisbonne"         ,  2705000, pays["Portugal"] ),
                new Ville("Londres"          ,  9046000, pays["Royaume-Uni"] ),
                new Ville("Lyon"             ,  2259411, pays["France"] ),
                new Ville("Minsk"            ,  2005000, pays["Biélorussie"] ),
                new Ville("Madrid"           ,  6497000, pays["Espagne"] ),
                new Ville("Manchester"       ,  2690000, pays["Royaume-Uni"]  ),
                new Ville("Milan"            ,  5270000, pays["Italie"] ),
                new Ville("Moscou"           , 12410000, pays["Russie"] ),
                new Ville("Naples"           ,  2198000, pays["Italie"] ),
                new Ville("Paris"            , 10816000, pays["France"] ),
                new Ville("Rome"             ,  3995000, pays["Italie"] ),
                new Ville("Saint Pétersbourg",  5383000, pays["Russie"] ),
                new Ville("Vienne"           ,  1901000, pays["Autriche"] )
            };

            // - Filtrer
            var moins1000km2 = listePays.Where(p => p.Superficie < 1000m);
            
            foreach(var élément in moins1000km2) {
                Console.WriteLine(élément);
            }
                        
            var top5pays = villes
                .OrderByDescending(v => v.Population)
                .Select(v => v.Pays)
                .Distinct()
                .Take(top);

            foreach(var élément in top5pays) {
                Console.WriteLine(élément);
            }
            
            // - Agréger
            var moyenneSuperficiePaysVilles5M = villes
                .Where(v => v.Population > 5_000_000)
                .Average(v => v.Pays.Superficie);            

            Console.WriteLine($"Superficie moyenne : {moyenneSuperficiePaysVilles5M:0.0} km²");

            var listeTop5 = top5pays.Aggregate(
                new StringBuilder(), 
                (sb, p) => sb.Append(sb.Length==0 ? p.Nom : $", {p.Nom}")
            );
            Console.WriteLine(listeTop5);

            // - Convertir
            var noms = listePays.Select(p => p.Nom).OrderBy(nom => nom).ToList();
            
            Console.WriteLine($"Position de 'France' : { noms.BinarySearch("France") }");
        }
    }
}
