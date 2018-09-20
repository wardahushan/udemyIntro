using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Udemy
{
    public class Lecture76
    {
        private static string path = @"C:\Users\wushan\Desktop\GitHub_Repos\udemyIntro\lorem_ipsum.txt";
        private static string[] words = HelperFunctions.GetWordsFromFile(path);

        internal static void RunProblem1()
        {
            // Lecture 76: Problem 1 
            Console.WriteLine($"Problem 1:\nThe number of words in lorem_ipsum.txt are: {words.Count()}");
        }

        internal static void RunProblem2()
        {
            // Lecture 76: Problem 2            
            int lengthOfLongestWord = words.Select(x => x.Length).ToArray().Max();
            string firstLongestWord = words.First(x => x.Length == lengthOfLongestWord);
            Console.WriteLine($"Problem 2:\nThe first longest word in lorem_ipsum.txt is: {firstLongestWord} and has length {lengthOfLongestWord}.");
        }

        internal static void RunLecture76()
        {
            // Header section 
            StringBuilder header = new StringBuilder();
            header.AppendLine("----------------------").AppendLine("LECTURE 76 EXERCISES").AppendLine("----------------------");
            Console.Write(header);

            RunProblem1();
            RunProblem2();
        }
    }
}