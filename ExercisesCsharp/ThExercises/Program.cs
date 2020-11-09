using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int x, y, sum = 0;
                double avg;Console.WriteLine("enter the 10 number");
                for(x=1;x<=10;x++)
                {
                    Console.WriteLine("num {0}",x);
                    y = Convert.ToInt32(Console.ReadLine());
                    sum += y;
                }Console.WriteLine("sum is:{0}", sum);
                avg=sum/10.0;
                Console.WriteLine("avg is:{0}", avg);
                Console.ReadKey();
            }
        }

    }
    
}

    