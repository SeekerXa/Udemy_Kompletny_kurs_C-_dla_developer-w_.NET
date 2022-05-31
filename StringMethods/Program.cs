using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SubString();
            Replace();
            Modify();
            AlterTextCase();
            Split();
            CheckString();
        }


        static void SubString(string userInput = "This is some very very very very very very very very very very very long text")
        {
            if (userInput.Length > 10)
            {
                //"this is some value".Substring(5) +> "is some value"
                var startSubString = userInput.Substring(0, 10); // First 10 chars
                var endSubString = userInput.Substring(userInput.Length - 10);
                Console.WriteLine(userInput);
                Console.WriteLine(startSubString + "..." + endSubString);
                Console.WriteLine(".......................................");
            }
        }
        static void Replace(string userInput = "Alison")
        {
            string template = "Hello {name},how are you? ";
            string output = template.Replace("{name}", userInput);
            Console.WriteLine(userInput);
            Console.WriteLine(template);
            Console.WriteLine(output);
            Console.WriteLine(".......................................");
        }
        static void Modify(string userInput = " some basic text   ")
        {
            var removeString = userInput.Remove(0, 10); // => first 10 chars
            var insertedString = userInput.Insert(6, "#######");   // insert extra string on selected place
            var trimmedString = insertedString.Trim();    // deleting first and last space
            Console.WriteLine(userInput);
            Console.WriteLine(removeString);
            Console.WriteLine(insertedString);
            Console.WriteLine(trimmedString);
            Console.WriteLine(".......................................");

        }
        static void AlterTextCase(string userInput = "AlA mA koTa, Bo lubi gO mieC")
        {
            var upperCased = userInput.ToUpper();
            var lowerCased = userInput.ToLower();
            Console.WriteLine(userInput);
            Console.WriteLine(upperCased);
            Console.WriteLine(lowerCased);
            Console.WriteLine(".......................................");
        }

        static void Split(string userInput = "Alison Rose Deck")
        {
            var splitedString = userInput.Split(' ');
            var first = splitedString[0];
            var second = splitedString[splitedString.Length - 1];
            Console.WriteLine(userInput);
            Console.WriteLine($"Hello {first} {second}");
            Console.WriteLine(".......................................");
        }

        static void CheckString(string userInput = "Textfile.txt")
        {
            var isTextFile = userInput.EndsWith(".txt");
            var startWith = userInput.StartsWith("fil");
            var containtext = userInput.Contains("text");
            Console.WriteLine(userInput);
            Console.WriteLine($"Is text file: {isTextFile}");
            Console.WriteLine($"starts with 'fil': {startWith}");
            Console.WriteLine($"contain 'text': {containtext}");
            Console.WriteLine(".......................................");

        }

    }
}
