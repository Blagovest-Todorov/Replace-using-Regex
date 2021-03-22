using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Nakov: 01, Branson: 78";
            string pattern = @"\d+";
            
            string replacement = "****";
            Regex regex = new Regex(pattern);

            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);
        }
    }
}
