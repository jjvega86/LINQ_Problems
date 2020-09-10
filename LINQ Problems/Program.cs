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

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
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

            // Problem 3: Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student. 
            // The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
            // drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.

            List<string> classGrades = new List<string>()   {
                                                            "80,100,92,89,65",
                                                            "93,81,78,84,69",
                                                            "73,88,83,99,64",
                                                            "98,100,66,74,55"
                                                            };

            double cumulativeTotal = 0;
            foreach (string s in classGrades)
            {               
                string[] grades = s.Split(','); // Split each string by comma before converting to ints
                var gradesInt = grades.Select(g => Int32.Parse(g)).ToList(); // select each string in array, parse to int, add to new list
                gradesInt.Remove(gradesInt.Min()); // remove lowest int from array
                cumulativeTotal += gradesInt.Average(); // add the average of the shrunk array to a cumulative total
                
            }

            var finalTotal = cumulativeTotal/classGrades.Count; // find average of all averaged grades divided by total strings in original list



            // Problem 4: Write a function that takes in a string of letters (i.e. “Terrill”) 
            // and returns an alphabetically ordered string corresponding to the letter frequency (i.e. "E1I1L2R2T1")

            string letters = "Terrill";
            var finalOutput = new StringBuilder();
            string loweredLetters = letters.ToUpper();
            char[] a = loweredLetters.ToCharArray();
            Array.Sort(a);

            
            foreach (char c in a)
            {
                if (a != null)
                {
                    

                    if(a.Count(letter => letter == c) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        finalOutput.Append(c);
                        finalOutput.Append(a.Count(letter => letter == c));
                        char[] temp = a.Where(letter => letter != c).ToArray();
                        a = temp;
                    }
                    
                    

                }
                else
                {
                        
                    break;
                }
            }

            Console.WriteLine(finalOutput);

            Console.ReadLine();





        }
    }
}
