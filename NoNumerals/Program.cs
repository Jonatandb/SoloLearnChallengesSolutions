using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    /*
        [19:54, 21/3/2020] 
        
        No Numerals  

        You write a phrase and include a lot of number characters (0-9), 
        but you decide that for numbers 10 and under you would rather write the word out instead. 
        Can you go in and edit your phrase to write out the name of each number instead of using the numeral? 

        Task: 
        Take a phrase and replace any instances of an integer from 0-10 and replace it with the English word 
        that corresponds to that integer.

        Input Format: 
        A string of the phrase in its original form (lowercase).

        Output Format: 
        A string of the updated phrase that has changed the numerals to words.

        Sample Input: 
        i need 2 pumpkins and 3 apples

        Sample Output: 
        i need two pumpkins and three apples

        Explanation: 
                    You would update the phrase to change '2' to 'two' and '3' to 'three'.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReplaceNumerals(input));

            Console.ReadKey();
        }

        public static string ReplaceNumerals(string input)
        {
            Dictionary<int, string> words = new Dictionary<int, string>();
            words.Add(0, "zero");
            words.Add(1, "one");
            words.Add(2, "two");
            words.Add(3, "three");
            words.Add(4, "four");
            words.Add(5, "five");
            words.Add(6, "six");
            words.Add(7, "seven");
            words.Add(8, "eigth");
            words.Add(9, "nine");
            words.Add(10, "ten");

            string newString = "";
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];
                if(currentLetter == '1' && input[i+1] == '0')
                {
                    newString += words[10];
                    i++;
                }
                else if (currentLetter == '1' && Int32.TryParse(input[i + 1].ToString(), out int result))
                {
                    newString += words[Convert.ToInt32(currentLetter.ToString())];
                    newString += " ";
                }
                else
                {
                    if(Int32.TryParse(currentLetter.ToString(), out int result2))
                    {
                        newString += words[Convert.ToInt32(currentLetter.ToString())];
                    }
                    else
                    {
                        newString += currentLetter.ToString();
                    }
                }
            }
            return newString;
        }
    }
}