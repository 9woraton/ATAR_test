using System;

namespace _4_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter row you want to creat triangle: ");
            try
            {
                int requestRow = int.Parse(Console.ReadLine());

                for (int i = 0; i <= requestRow; i++)
                {
                    for (int jrow = 0; jrow < i; jrow++)
                    {
                        Console.Write("1");
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Please enter Value.");
            }
            Console.ReadKey();
        }
    }
}
