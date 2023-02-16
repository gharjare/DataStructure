using DataStructureAlgorithm1;
using System.Collections;

namespace DataStrctureAlgorithm1
{ 
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Datastructure algorithm");
            Pallindrome obj = new Pallindrome();
            for (int i = 1; i < 1000; i++)
            {
                if (obj.isPrime(i) && obj.isPalindrome(i))
                    Console.WriteLine(i + " ");
            }


        }
    }
}
