using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace app_06
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
            // Thread.GetDomain().SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            // Console.WriteLine(Thread.CurrentPrincipal.Identity.Name);
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
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(utilisateur.Identifiant),
                    utilisateur.Roles.Select(r => r.ToString()).ToArray()
                );
            }
            else
            {
                Console.WriteLine("Identifiant ou mot de passe inconnu");
                Thread.GetDomain().SetPrincipalPolicy(PrincipalPolicy.UnauthenticatedPrincipal);
            }

            try
            {
                RéservéAuxPersonnesAuthentifiées();
                RéservéAuxAdmins();
            }
            catch(UnauthorizedAccessException e)
            {
                Console.Error.WriteLine($"Accès refusé : {e.Message}");
            }
        }

        public static void RéservéAuxPersonnesAuthentifiées() 
        {
            var identité = Thread.CurrentPrincipal?.Identity;

            if(identité==null || !identité.IsAuthenticated)
            {
                throw new UnauthorizedAccessException("Non authentifié-e");
            }
            Console.WriteLine($"Bienvenue dans votre espace {identité.Name}");
        }

        public static void RéservéAuxAdmins() 
        {
            // var mandatWindows = Thread.CurrentPrincipal as WindowsPrincipal;
            
            // if(mandatWindows.IsInRole(WindowsBuiltInRole.Administrator))
            var mandat = Thread.CurrentPrincipal;

            if(mandat == null || !mandat.IsInRole(Role.Admin.ToString()))
            {
                throw new UnauthorizedAccessException("Non admin");
            }
            Console.WriteLine("Bienvenue aux admins");
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
