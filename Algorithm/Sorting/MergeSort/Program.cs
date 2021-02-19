using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortMe = new int[] { 4, 2, 9, 6, 5, 8 };
            //Split(sortMe);
            //MergeSort sorted = new MergeSort();
            Merge(sortMe, 0, sortMe.Length - 1);

            //Console.WriteLine(string.Join("", newSort));
            //Console.ReadKey();
            Console.WriteLine(string.Join("", sortMe));
            Console.ReadKey();

        }

        public static void Split(int[] A, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            
           
           // int mid = (int) Math.Round((double)n / 2, MidpointRounding.AwayFromZero);
            int[] LeftA = new int[n1];
            int[] RightA = new int[n2];
           
            for (i = 0; i < n1; i++)
            {
                LeftA[i] = A[l+i];

            }
            for (j = 0; j < n2; j++)
            {
                RightA[j] = A[m+1+j];

            }

            i = 0;
            j = 0;
            k = l;
            while(i<n1 && j < n2)
            {
                if (LeftA[i] <= RightA[j])
                {
                    A[k] = LeftA[i];
                    i = i + 1;
                }
                else
                {
                    A[k] = RightA[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            if (i < n1)
            {
                A[k] = LeftA[i];
                i = i + 1;
                k = k + 1;
            }
            else if (j < n2)
            {
                A[k] = RightA[j];
                j = j + 1;
                k = k + 1;
            }

            
        }

        public static void Merge(int[] A, int l, int r)
        {
            if (l < r)
            {
                int m= (l + r)  / 2;
                Merge(A,l,m);
                Merge(A,m+1,r);
                Split(A, l,m,r);

                
            }
               
                 
        }

    }
}
