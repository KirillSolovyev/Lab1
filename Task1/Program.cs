using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());                                      // Get the number of numbers
            int nPrime = 0;                                                                   // Create counter of prime numbers
            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse); // Create an array of read numbers
            List<int> arrPrime = new List<int>();                                             // Create a List for prime numbers
            for(int i = 0; i < arr.Length; i++) {                                             // Check each element of the array 
                if(IsPrime(arr[i])) {                                                         // Call the method IsPrime, checking whether a number is prime
                    nPrime++;                                                                 // Increment prime counter
                    arrPrime.Add(arr[i]);                                                     // Add prime number to the prime numbers' array
                }
            }
            Console.WriteLine(nPrime);                                                        // Output the total number of prime numbers
            foreach(int el in arrPrime) {                                                     // Loop through the array
                Console.Write(el + " ");
            }
        }
        static bool IsPrime(int a) {                                                          // Create a function to check if a number is prime
            if(a == 1) {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(a); i++) {
                if(a % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }
}
