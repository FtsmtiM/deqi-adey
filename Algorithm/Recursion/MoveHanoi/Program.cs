using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 6,5,4,3,2,1 };
            Hanoi(A, A.Length);
          
            
        }
        static int[] B = new int[6];
        static int[] temp = new int[5];
        static void Hanoi(int[] X, int L)
        {
            
            if (L == 1)
            {
                B[0] = X[0];
                //HanoiToB(temp, temp.Length-1);
                Console.WriteLine(string.Join("", HanoiToB(temp,temp.Length-1)));
                Console.ReadLine();
            }
           
            temp[X.Length-L] = X[L-1];
            Hanoi(X, L - 1);
           
        }
        static int[] HanoiToB(int[] T, int y)
        {
            
            if (y < 0){
                return B;
            }
            B[T.Length - y] = T[y];
            HanoiToB(T, y - 1);

            return B;
        }
    }
}
