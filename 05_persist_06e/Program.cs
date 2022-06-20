using System;
using System.IO;
using System.Xml;

namespace persist_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = 
                @"<?xml version='1.0' encoding='utf-16'?>
                <!--Généré par persist_06, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-->
                <racine nombre-valeurs='3'>
                <valeurs>
                    <val>25.2</val>
                    <val>titi</val>
                    <val>null</val>
                </valeurs>
                </racine>";

            XmlDocument doc = new();
            
            doc.LoadXml(source);
            Console.WriteLine(doc.DocumentElement.GetAttribute("nombre-valeurs"));
            foreach(var val in doc.GetElementsByTagName("val"))
            {
                Console.WriteLine($"- {(val as XmlElement).InnerText}");
            }

            using(StringReader str = new(source)) 
            using(var reader = XmlReader.Create(str))
            {
                if(!reader.ReadToFollowing("racine"))
                {
                    Console.Error.WriteLine("Racine introuvable");
                }
                if(!int.TryParse(reader.GetAttribute("nombre-valeurs"), out var nb))
                {
                    nb = 0;
                }
                Console.WriteLine($"{nb} valeur(s)");
                if(reader.ReadToFollowing("valeurs")) 
                {
                    while(reader.Read())
                    {
                        if(reader.NodeType == XmlNodeType.Element && reader.Name=="val")
                        {
                            Console.WriteLine($"- {reader.ReadInnerXml()}");
                        }
                    }
                }
            }
        }
    }
}
