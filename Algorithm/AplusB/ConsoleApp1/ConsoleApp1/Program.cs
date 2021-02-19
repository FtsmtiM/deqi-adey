using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class APlusB
    {
        static void Main(string[] args)
        {
            int a, b;
            string tokens = Console.ReadLine();
            string[] token = tokens.Split();
            a = Int32.Parse(token[0]);
            b = Int32.Parse(token[1]);
            Console.WriteLine(a + b);
            Console.ReadKey();

        }
    }
}
