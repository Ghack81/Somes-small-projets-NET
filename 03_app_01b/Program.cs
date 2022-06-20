using System;
using System.Collections.Generic;

namespace app_01
{
    class Program
    {
        public record Pays(string Nom, decimal Superficie);
        public record Ville(string Nom, int Population, Pays Pays);
        static void Main(string[] args)
        {
            List<Pays> listePays = new () {
                new Pays("Albanie"           , 28748m),
                new Pays("Allemagne"         , 357578m),
                new Pays("Andorre"           , 468m),
                new Pays("Arménie"           , 29743m),
                new Pays("Autriche"          , 83870m),
                new Pays("Belgique"          , 30528m),
                new Pays("Biélorussie"       , 207600m),
                new Pays("Bosnie-Herzégovine", 51129m),
                new Pays("Bulgarie"          , 110910m),
                new Pays("Chypre"            , 9251m),
                new Pays("Croatie"           , 56542m),
                new Pays("Danemark"          , 43094m),
                new Pays("Espagne"           , 518000m),
                new Pays("Estonie"           , 45226m),
                new Pays("Finlande"          , 338145m),
                new Pays("France"            , 643801m),
                new Pays("Géorgie"           , 69700m),
                new Pays("Grèce"             , 131940m),
                new Pays("Hongrie"           , 93030m),
                new Pays("Irlande"           , 70280m),
                new Pays("Islande"           , 103000m),
                new Pays("Italie"            , 301234m),
                new Pays("Kosovo"            , 10887m),
                new Pays("Lettonie"          , 64589m),
                new Pays("Liechtenstein"     , 160m),
                new Pays("Lituanie"          , 65200m),
                new Pays("Luxembourg"        , 2586m),
                new Pays("Macédoine du Nord" , 25333m),
                new Pays("Malte"             , 316m),
                new Pays("Moldavie"          , 33843m),
                new Pays("Monaco"            , 2m),
                new Pays("Monténégro"        , 13800m),
                new Pays("Norvège"           , 324220m),
                new Pays("Pays-Bas"          , 41526m),
                new Pays("Pologne"           , 312685m),
                new Pays("Portugal"          , 92042m),
                new Pays("Roumanie"          , 237500m),
                new Pays("Royaume-Uni"       , 244820m),
                new Pays("Russie"            , 17075200m),
                new Pays("Saint-Marin"       , 61m),
                new Pays("Serbie"            , 77589m),
                new Pays("Slovaquie"         , 48845m),
                new Pays("Slovénie"          , 20273m),
                new Pays("Suède"             , 450295m),
                new Pays("Suisse"            , 41290m),
                new Pays("Tchéquie"          , 78866m),
                new Pays("Turquie"           , 783562m),
                new Pays("Ukraine"           , 603628m),
                new Pays("Vatican"           , 0.4m)
            };
            Dictionary<string, Pays> pays=new();

            foreach(var p in listePays) {
                pays[p.Nom] = p;
            }
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
            
            // - Agréger
            
            // - Convertir
            
        }
    }
}
