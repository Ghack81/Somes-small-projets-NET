using System.Text.RegularExpressions;  
using System;  
namespace RegularExpressionsSample {  
    class Program {  
        static void Main(string[] args) {  
            string regularExpression = @ "^(?=.*?\d.*?\d)(?=.*?\w.*?\w)[\d\w]{8,20}$";  
            Console.WriteLine("Please input password for check:");  
            string inputString = Console.ReadLine();  
            if (inputString != "" && Regex.IsMatch(inputString, regularExpression)) {  
                Console.WriteLine("It's correct security password");  
            } else {  
                Console.WriteLine("It's incorrect password.");  
            }  
            Console.Read();  
        }  
    }  
}  
