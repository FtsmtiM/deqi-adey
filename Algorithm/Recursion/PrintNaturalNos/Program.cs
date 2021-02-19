using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNaturalNos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Natural numbers to print..");
            int n = Convert.ToInt32(Console.ReadLine());

            //printToN(n, 1);
            //print N to 1
            // printNto(n, n);
            //pint digits separately
            //separateDigit(n);
            //count n numbers
            //countN(n);
            Console.WriteLine("All even numbers less than {0}", n);
            //printOddEven(n,2);
            //Console.WriteLine("\n\n");
            //Console.WriteLine("All odd numbers less than {0}", n);
            //printOddEven(n, 1);
            //Console.WriteLine("{0}", sumOfN(n, 1));
            printPrime(n, n-1);
            Console.ReadKey();
        }

        static int printToN(int n, int val)
        {
            if (n < 1)
            {
                return val;
            }
            n--;
            Console.WriteLine("{0}", val);
            return (printToN(n, val + 1));
        }

        static int printNto(int n, int val)
        {
            if (n < 1)
            {
                return val;
            }
            n--;
            Console.WriteLine("{0}", val);
            return (printNto(n, val - 1));
        }

        static int sumOfN(int n, int val)
        {
            if (n < 1)
            {
                return 0;
            }
            
            return val + sumOfN(n-1, val + 1);
            
        }

        static void separateDigit(int n)
        {
            if (n < 10)
            {
                Console.Write("{0}", n);
                return;
            }

            separateDigit(n / 10);
            Console.Write("{0}", n % 10);
        }

        static void countN(int n, int i=0)
        {
            if (n < 10)
            {
                i++;
                Console.Write("{0}", i);
                return;
            }
            i++;
            countN(n / 10,i);
            
        }

        static void printOddEven(int n, int l)
        {
            if (l > n)
            {
                return;
            }
            Console.Write("{0}", l);
            printOddEven(n, l + 2);
        }

        static void printPrime(int n, int l)
        {
            if (l == 1)
            {
                if (n == 2)
                {
                    Console.Write("{0}", n);
                }
                return;
            }
            else
            {
                if (n % l == 0)
                {
                    Console.Write("{0}", n);
                    return;

                }
                else
                {
                    printPrime(n, l - 1);
                }
            }
            
            printPrime(n - 1, n - 2);
//Console.Write("{0}", n);
            
            
           
            
        }
    }
}
