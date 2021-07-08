using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsFibonaciDll
{
    public class clsMath
    {
        
        public long[] GenFibonacci(int n)
        {
    
            long[] fibonaci = new long[n];
            long broj1 = 0;
            long broj2 = 1;
            long rez = 0;
            fibonaci[0] = broj1;
            fibonaci[1] = broj2;
            for (int i = 2; i < n; i++)
            {
                rez = broj1 + broj2;
                broj1 = broj2;
                broj2 = rez;
                fibonaci[i] = rez;
            }
        
        
            return fibonaci;
        }
    }
}
