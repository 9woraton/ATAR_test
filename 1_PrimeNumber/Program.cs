using System;

namespace _1_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number you want to find \"Primenumber\" :");
            try
            {
                int primeValue = int.Parse(Console.ReadLine());
                for (int i = 0; i <= primeValue; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.WriteLine("{0} is prime.", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not prime.", i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter Value.");
            }
            Console.ReadKey();

        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }

}

//https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
