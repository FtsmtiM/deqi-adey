using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Rediet";
            Console.WriteLine(ReverseMe(str));
            Console.ReadKey();
        }

        static string ReverseMe(string X)
        {
            if(X.Length == 0)
            {
                return "";
            }
            else
            {
                return X[X.Length - 1] + ReverseMe(X.Substring(0, X.Length - 1));
            }
        }

    
    }
}
