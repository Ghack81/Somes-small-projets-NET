using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace persist_07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produit ballon = new("Ballon", 3.5m, 0.5m, false);
            Produit tongs = new("Tongs", 5.9m, 2.4m, false);
            var cmd = new Commande("AB123", new Ligne[]{
                new Ligne{ Produit = ballon, Qté = 2 },
                new Ligne{ Produit = tongs , Qté = 1 }
            });

            Console.WriteLine(JsonSerializer.Serialize(cmd));

            var xml=new XmlSerializer(typeof(Commande));

            using(var str=new StringWriter())
            {                
                xml.Serialize(str, cmd);
                Console.WriteLine(str.ToString());
            }
        }

        public class Produit
        {
            public Produit() { }
            public Produit(string nom, decimal prix, decimal achat, bool rupture)
                => (Nom, Prix, Achat, Rupture) = (nom, prix, achat, rupture);

            [XmlText]
            public string Nom { get; set; }

            [XmlAttribute("prix")]
            public decimal Prix;

            [JsonIgnore, XmlIgnore]
            public decimal Achat { get; set; }

            [XmlAttribute("rupture")]
            public bool Rupture { get; set; }
        }

        public record Ligne
        {
            public Produit Produit { get; init; }

            [JsonPropertyName("qte"), XmlAttribute("qte")]            
            public int Qté { get; init; }

            [XmlIgnore]
            public decimal Prix => Produit.Prix * Qté;
        }
        
        public class Commande
        {
            public Commande() {}
            public Commande(string @ref, Ligne[] contenu) 
                => (Ref, Contenu) = (@ref, contenu);

            public string Ref { get; set;}
            public Ligne[] Contenu { get; init; }
            public decimal Total => Contenu.Sum(l => l.Prix);
        }
    }
}
