using System;

namespace binary2decimal
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter binary number: ");
            string userInput = Console.ReadLine();
            int size = userInput.Length;
            int pow = size - 1;
            int result = 0;

            for (int i = 0; i < size; i++)
            {
                int value = power(2, pow); 
                char ch = userInput[i];
                int bit = (ch - '0');//converts char into 1 or 0 as int value
                result = result + bit * value;
                pow = pow - 1;
            }
            Console.WriteLine("Decimal is " + result);
        }

        static int power(int num, int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result = result * num;
            }
            return result;
        }
    }
}
