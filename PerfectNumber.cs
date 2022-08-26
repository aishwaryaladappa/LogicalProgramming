using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class PerfectNumber
    {
        public static void ChechPerfectNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the Perfect number within a given number of range:");
            Console.WriteLine("input the starting range or number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the ending range or number");
            mx = Convert.ToInt32(Console.ReadLine());
            for (n = mn; n < mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                
                    Console.WriteLine("{0} ",n);
                

            }
        }
    }
    
}
