using System;

namespace _2_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number Factorial you want :");
            try
            {
                int facGoal = int.Parse(Console.ReadLine());
                Int64 value = 1;

                for (int i = facGoal; i > 0; i--)
                {
                    value *= i;
                }
                Console.WriteLine("Value of " + facGoal + "! = " + value);
            }
            catch
            {
                Console.WriteLine("Please enter Value.");
            }
            Console.ReadKey();
        }
    }
}
