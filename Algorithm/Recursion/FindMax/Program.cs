using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 6, 3, 8, 5, 7 };
            int k = A.Length;
            int max = GetMax(A, k);

            Console.WriteLine(max);
            Console.ReadKey();
        }

        public static int GetMax(int[] A, int len)
        {
                  
            if (len == 1)
            {
                return A[0];
             
            }
           
            return max(GetMax(A,len-1), A[len-1]);
        }

        private static int max(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
