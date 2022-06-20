using System;
using System.Text.RegularExpressions;

namespace info_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var bic = "ATCICIAB";
            
            Console.WriteLine(Regex.IsMatch(input: bic, pattern: "[A-Z]{6}[A-Z0-9]{2,5}") ? "Valide" : "Non valide");
            
            var twitGeorgeSand = "Tu fuyais la #solitude et la trouvait #partout.";
            
            var hashtags = Regex.Matches(twitGeorgeSand, pattern:@"#\w+");

            foreach(Match tag in hashtags) {
                Console.WriteLine($"{tag.Value}");
            }

            var html = Regex.Replace(
                twitGeorgeSand, 
                pattern:@"#\w+", 
                m => $"<a href='?tag={m.Value.Substring(1)}'>{m.Value}</a>"
            );
            Console.WriteLine(html);
        }
    }
}
