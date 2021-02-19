using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Factorial...");
            string toReturn= Console.ReadLine();

            int calMe = Int32.Parse(toReturn);

                      
            Console.WriteLine("The factorial is " + FactorCal(calMe));
            Console.WriteLine("The fibonachi is " + Fibnoci(calMe));
            Console.ReadKey();
        }

        public static int FactorCal(int n)
        {
            
            if (n == 1)
            {
                return 1;

            }
            else
            {
                int result = n * FactorCal(n - 1);
                return result;
            }
            
        }

        public static int Fibnoci(int n)
        {
            if(n==0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibnoci(n - 1) + Fibnoci(n - 2);
            }
        }
            
    }
}
