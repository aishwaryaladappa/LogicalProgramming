using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class FibonaciSeries
    {
        public static void DisplayFibonaciSeries()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the number of elementfor the Fibonaci series");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
        }
    }


    
}
