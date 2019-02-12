using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine()); //Get length of the array 
            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse); // Get array
            int[] SecArr = new int[n * 2]; // Create new array 
            int cnt = -1; // counter
            for(int i = 0; i < arr.Length; i++) { // Go through the initial array and inserting elements to the second array
                SecArr[++cnt] = arr[i];
                SecArr[++cnt] = arr[i];
            }

            foreach(int el in SecArr) { // Print all 
                Console.Write(el + " ");
            }
        }
    }
}
