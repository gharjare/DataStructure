using DataStructureAlgorithm1;
using System.Collections;

namespace DataStrctureAlgorithm1
{ 
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Datastructure algorithm");
            Console.WriteLine("Enter starting point : ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Point : ");
            int end = Convert.ToInt32(Console.ReadLine());
            ArrayList primeNumbers = Prime.FindPrimeNumbers(start, end);
            Console.WriteLine($"\nAll the prime numbers between {start} and {end} are :");
            foreach (int prime in primeNumbers)
            {
                Console.WriteLine(prime);
            }


        }
    }
}
