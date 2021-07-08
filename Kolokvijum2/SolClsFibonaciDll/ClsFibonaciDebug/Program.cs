using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsFibonaciDll;

namespace ClsFibonaciDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMath x = new clsMath();

            long[] rezultat = x.GenFibonacci(10);
            foreach(long clan in rezultat)
            {
                Console.WriteLine(clan);
            }
                
            Console.ReadKey();
        }
    }
}
