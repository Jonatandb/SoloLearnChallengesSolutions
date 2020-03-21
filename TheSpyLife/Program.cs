using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    [18:55, 21/3/2020] 
    
    The Spy Life  

    You are a secret agent, and you receive an encrypted message that needs to be decoded. 
    The code that is being used flips the message backwards and inserts non-alphabetic 
    characters in the message to make it hard to decipher.

    Task: 
    Create a program that will take the encoded message, flip it around, 
    remove any characters that are not a letter or a space, and output the hidden message.

    Input Format:  
    A string of characters that represent the encoded message.

    Output Format: 
    A string of character that represent the intended secret message.

    Sample Input: 
    d89%l++5r19o7W *o=l645le9H

    Sample Output: 
    Hello World
    
    Explanation: 
                    If you remove everything that isn't a letter or space from the original 
                    message and flip it around, you get 'Hello World'.
*/
namespace TheSpyLife
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //Console.WriteLine("Input string: {0}",input);

            input = RemoveInvalidChars(input);

            //Console.WriteLine("Input without invalid chars: {0}", input);

            string decodedInput = Reverse(input);

            //Console.WriteLine("Input decoded (cleaned and reverse): {0}", decodedInput);
            Console.WriteLine(decodedInput);

            Console.ReadKey();
        }

        /// <summary>
        /// Remove any characters that are not a letter or a space
        /// </summary>
        /// <param name="s">Invalid string</param>
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
                    (
                        (currentChar >= 65 && currentChar <= 90)
                        ||
                        (currentChar >= 97 && currentChar <= 122)
                    )
                )
                {
                    //Console.WriteLine("Valid current char -> s[{0}] = {1}", i, currentChar);
                    cleanedString += currentChar ;
                }
                else
                {
                    //Console.WriteLine("Invalid current char -> s[{0}] = {1}", i, currentChar);
                }
            }
            return cleanedString ;
        }

        static string Reverse(string s)
        {
            string newString = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                newString += s[i];
            }
            return newString;
        }
    }
}
