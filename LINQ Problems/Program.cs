using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Using LINQ, write a function that returns all words that contain the substring “th” from a list

            List<string> words = new List<string>() { "the", "bike", "this",  "it", "tenth", "mathematics" };
            var wordsWithTh = words.Where(w => w.Contains("th"));
            foreach (var word in wordsWithTh)
            {
                Console.WriteLine(word);
            }

            // Problem 2: Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            var listWithoutDuplicates = names.Distinct().ToList();
            foreach (var name in listWithoutDuplicates)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
