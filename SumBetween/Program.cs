using System;

namespace SumBetween
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Result is: " + sumBetween(5, 10));
           Console.WriteLine("Result is: " + sumBetween(34, 67));
        }

        static int sumBetween(int a, int b) 
        {
          int sum = 0;
          for (int i = a; i <= b; i++)
          {
            sum = sum + i;  
          }
          return sum;
        }
    }
}
