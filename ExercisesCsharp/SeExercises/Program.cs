using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, sum = 0;
            for( j =1;j<=10;j++)
            {
                Console.WriteLine("{0}", j);
                sum = sum + j;
            }Console.WriteLine("sum is = {0}", sum);
            Console.ReadKey();
        }
    }
}
