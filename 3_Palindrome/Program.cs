using System;

namespace _3_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Palindrome : ");
            try
            {
                string paValue = Console.ReadLine();

                Console.WriteLine("is Palindrome? : " + getStatus(paValue));
            }
            catch
            {
                Console.WriteLine("Please enter Value.");
            }
        }
        public static bool getStatus(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}

//https://stackoverflow.com/questions/9790749/check-if-a-string-is-a-palindrome
