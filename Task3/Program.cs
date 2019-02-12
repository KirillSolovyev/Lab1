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
            int[] SecArr = new int[n * 2];
            int cnt = -1;
            for(int i = 0; i < arr.Length; i++) {
                SecArr[++cnt] = arr[i];
                SecArr[++cnt] = arr[i];
            }

            foreach(int el in SecArr) {
                Console.Write(el + " ");
            }
        }
    }
}
