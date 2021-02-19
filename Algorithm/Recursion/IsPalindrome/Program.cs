using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "dfghfd";
            //Console.WriteLine(Ispal(str));

            Console.WriteLine("{0}",(double)powerOf(2, -7));
            Console.ReadKey();
        }

        static bool Ispal(string x)
        {
            if (x.Length == 1 || x.Length == 0)
            { return true; }

            if (x[0] != x[x.Length - 1])
            { return false; }

            return Ispal(x.Substring(1, x.Length-2));
            
        }

        static double powerOf(int x, int n)
        {
            
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return (double)1/powerOf(x,-n);
            }
           
            if(n%2 != 0)
            {
                return x * powerOf(x, n - 1);
            }
            int y = (int)powerOf(x, n/2);
            return y * y;
        }
    }
}
