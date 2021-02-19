using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string files = @"C:\Users\Surface Pro 4\Documents\Kommun\may";
            System.IO.DirectoryInfo dir = new DirectoryInfo(files);
           // int fcount = (from file in Directory.EnumerateFiles(files, "*.*" ) select file).Count();
            int fcount = dir.GetFiles().Count();
            Random rnd = new Random();
            int newrnd = rnd.Next(2, 40);
            
            //DirectoryInfo newD = dir.CreateSubdirectory("Subdir"+newrnd);

            Console.WriteLine(fcount + "files available");
            Console.ReadKey();
        }
    }
}
