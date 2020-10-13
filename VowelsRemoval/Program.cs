using System;

namespace VowelsRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter");
            string userInput = Console.ReadLine();
            Console.WriteLine("Result string is: " + removeVowels(userInput));
        }

        static string removeVowels(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == 'a' || ch == 'o' || ch == 'e' || ch == 'i' || ch == 'y' || ch == 'u')
                {
                    continue;
                }
                else
                {
                    result = result + ch;
                }
            }
            return result;

        }
    }
}
