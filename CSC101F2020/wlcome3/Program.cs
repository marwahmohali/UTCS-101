using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wlcome3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            while(number>0)
            {
                Console.WriteLine("enter postive number");
                number = Convert.ToInt32(Console.ReadLine());
            }Console.WriteLine("very good");
        }
    }
}
