using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toSort = new int[] { 4, 7, 2, 34, 32, 5};
            insertSort(toSort);
            Console.WriteLine(string.Join(",", toSort));

            Console.ReadKey();
        }

        static void insertion(int[] A, int start, int value)
        {
            int temp = 0;
            for (int i = start; i > 0; i--)
            {
                if(value < A[i - 1])
                {
                    temp = A[i];
                    A[i] = A[i - 1];
                    A[i - 1] = temp;

                }
                else
                {
                    return;
                }

            }
                                
        }

        static void insertSort(int[] A)
        {
            for (int j = 1; j < A.Length; j++)
            {
                insertion(A, j , A[j]);
            }

        }
    }
}
