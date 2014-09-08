using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStatsLambda("Hey hey hey! I'm coder Albert. Write programs erry day.");
            Console.ReadKey();
        }

        static void TextStatsLambda(string input)
        {
            //Convert input to lower for data clarity
            string lower = input.ToLower();
            //Characters = Length of input
            int characters = input.Length;
            //Number of words
            int numWords = input.Split(' ').ToList().Count;
            //Vowels = Count of aeiou in string
            int vowels = lower.Count(x => "aeiou".Contains(x));
            //Consonants = Count of all non-vowel letters in string
            int consonants = lower.Count(x => "bcdfghjklmnpqrstvwxyz".Contains(x));
            //Special = Everything not a consonant or a vowel
            int special = characters - vowels - consonants;
            //Longest = OrderBy length of word descending, take first word as longest
            string longest = (from x in lower.Split(' ')
                               orderby x.Length descending 
                               select x).First();
            //Shortest = OrderBy length of word ascending, take first word as shortest
            string shortest = (from x in lower.Split(' ')
                               orderby x.Length ascending
                               select x).First();

            Console.WriteLine("Your string: " + input + "\nCharacters: " + characters + "\nWords: " + numWords + "\nVowels: " + vowels + "\nConsonants: " + consonants + "\nSpecial: " + special + "\nLongest word: " + longest + "\nShortest word: " + shortest);
        }
    }
}
