using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    /*
        [19:37, 21/3/2020] 
        
        Symbols  

        There is a problem with your keyboard: it randomly writes symbols when you are typing a text. 
        You need to clean up the text by removing all symbols.

        Task: 
        Take a text that includes some random symbols and translate it into a text that has none of them. 
        The resulting text should only include letters and numbers.

        Input Format: 
        A string with random symbols.

        Output Format: 
        A string of the text with all the symbols removed.

        Sample Input: 
        #l$e%ts go @an#d@@ g***et #l#unch$$$

        Sample Output: 
        lets go and get lunch
        
        Explanation: 
                        If you take out every symbol and leave only the letters and numbers, your text says 'lets go and get lunch'.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //Console.WriteLine("Input string: {0}",input);

            string decodedInput = RemoveInvalidChars(input);

            //Console.WriteLine("Input without invalid chars: {0}", decodedInput);

            Console.WriteLine(decodedInput);

            Console.ReadKey();
        }

        /// <summary>
        /// Remove any characters that are not a letter, number or a space
        /// </summary>
        /// <param name="s">Input</param>
        /// <returns>Cleaned string</returns>
        static string RemoveInvalidChars(string s)
        {
            string cleanedString = "";

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (
                    (currentChar == ' ')
                    ||
                    (currentChar >= 48 && currentChar <= 57)
                    ||
                    (
                        (currentChar >= 65 && currentChar <= 90)
                        ||
                        (currentChar >= 97 && currentChar <= 122)
                    )
                )
                {
                    //Console.WriteLine("Valid current char -> s[{0}] = {1}", i, currentChar);
                    cleanedString += currentChar;
                }
                else
                {
                    //Console.WriteLine("Invalid current char -> s[{0}] = {1}", i, currentChar);
                }
            }
            return cleanedString;
        }
    }
}
