using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammark
{
    class Program
    {
        static void Main(string[] args)
        {

            int exammark = 58;
            int labmark = 11;
            int sum = 5;

            if (exammark >= 50)
            {
                if (labmark > 10)
                {
                    sum = exammark + 20;
                    Console.WriteLine("sum = {0}", sum);
                    Console.ReadKey();
                }
                else
                {
                    sum = exammark + 10;
                    Console.WriteLine("sum = {0}", sum);
                    Console.ReadKey();
                }
            }
        }
    }
}
