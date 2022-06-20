using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace app_05
{
    enum Role {
        Admin,
        RH,
        Ventes,
        Membre
    }
    class Program
    {
        static readonly Utilisateur[] utilisateurs = {
            new Utilisateur("Alice", "MfemXjFVhqwZi9eYtmKc5JA9CJlHbVdBqfMuLlIbamY=", new Role[]{ Role.Admin }), // Mdp : toto
            new Utilisateur("Bob"  , "zOZjFrTBxZ35SjWvuAzs2C0ajZG1VAIlV+EV9cJ19RU=", new Role[]{ Role.Membre, Role.RH }), // Mdp : titi
            new Utilisateur("Carol", "6wKV2Y83rp6VECr655LVQBN74t7fbEsAVwqx0fNV0DM=", new Role[]{ Role.Membre, Role.Ventes })  // Mdp : tutu
        };
        static void Main(string[] args)
        {
            var annuaire = utilisateurs.ToDictionary(u => u.Identifiant.ToLowerInvariant());
            
            Console.Write("Identifiant : ");
            var identifiant = Console.ReadLine();
            
            Console.Write("Mot de passe : ");
            var motDePasse = ReadPassword();  

            string hashMdp;
            using(var hash = SHA256.Create()) 
            {
                hashMdp = Convert.ToBase64String(hash.ComputeHash(Encoding.UTF8.GetBytes(motDePasse)));
            }          
            if( annuaire.TryGetValue(identifiant.ToLowerInvariant(), out var utilisateur)
                && utilisateur.Authentifier(identifiant, hashMdp) ) 
            {
                Console.WriteLine("Connexion acceptée");
            }
            else
            {
                Console.WriteLine("Identifiant ou mot de passe inconnu");
            }
        }

        public record Utilisateur(string Identifiant, string HashMdp, Role[] Roles) 
        {
            public bool Authentifier(string identifiant, string hashMdp) =>
                identifiant.Equals(Identifiant, StringComparison.InvariantCultureIgnoreCase)
                && hashMdp.Equals(HashMdp, StringComparison.InvariantCulture);
        }

        public static string ReadPassword()
        {
            StringBuilder motDePasse = new(); 
            ConsoleKeyInfo touche;

            while((touche = Console.ReadKey(intercept: true)).Key!=ConsoleKey.Enter) 
            {
                if(touche.Key==ConsoleKey.Backspace) 
                {
                    motDePasse.Length--;
                }
                else if(!char.IsControl(touche.KeyChar))
                {
                    Console.Write("*");
                    motDePasse.Append(touche.KeyChar);
                }
            }
            Console.WriteLine();

            return motDePasse.ToString();
        } 
        
    }
}
