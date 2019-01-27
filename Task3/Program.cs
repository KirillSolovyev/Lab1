using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3 {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
            for(int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " " + arr[i] + " ");
            }
        }
    }
}
