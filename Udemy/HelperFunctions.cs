using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Udemy
{
    public static class HelperFunctions
    {
        internal static string IsConsecutiveNumbers(List<int> numbersDouble)
        {            
            List<int> copiedNumbers = new List<int>(numbersDouble);
            copiedNumbers.Sort();

            for (int i = 1; i < copiedNumbers.Count; i++)
            {
                if (Math.Abs(copiedNumbers[i] - copiedNumbers[i - 1]) != 1)
                {
                    return "Not consecutive";
                   
                }
            }

            return "Consecutive";
        }

        internal static string[] GetWordsFromFile(string path)
        {
            return File.ReadAllText(path).Split(' ').Select(x => Regex.Replace(x, "[^a-zA-Z]", "")).ToArray();
        }

        internal static List<int> ParseHyphenatedNumbersToList(string numbersList)
        {
            return numbersList.Split('-').Select(x => Int32.Parse(x)).ToList();
        }

        internal static List<int> ParseColonSeperatedNumbersToList(string numbersList)
        {
            return numbersList.Split(':').Select(x => Int32.Parse(x)).ToList();
        }


        internal static bool DuplicatesInList(List<int> numbersDouble)
        {
            return numbersDouble.Distinct().Count() != numbersDouble.Count(); 
        }

        internal static string Validate24HourUserTime(string userTime)
        {
            string returnString = string.Empty;

            if (string.IsNullOrWhiteSpace(userTime))
            {
                returnString = "Invalid.";
            }
            else
            {
                List<int> userTimeToValidate = ParseColonSeperatedNumbersToList(userTime);
                returnString = userTimeToValidate.First() >= 0 && userTimeToValidate.First() <= 23 && userTimeToValidate.Last() >= 0 && userTimeToValidate.Last() <= 59 ? "Ok" : "Invalid";
            }

            return returnString;
        }

        internal static string ParseAsPascalCase(string userWords)
        {
            string[] wordsArray = userWords.Split(' ').ToArray();
            string pascalCase = string.Empty;

            foreach (string word in wordsArray)
            {
                pascalCase += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            }

            return pascalCase;
        }

        internal static int CountVowelsInString(string word)
        {
            return word.ToLower().ToCharArray().Where(x => x.ToString() == "a" || x.ToString() == "e" || x.ToString() == "i" || x.ToString() == "o" || x.ToString() == "u").Count();
        }
    }
}
