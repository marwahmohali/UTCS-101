using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 5;
            if (x > 75)
            {
                Console.WriteLine("not bad sutent");
                Console.ReadKey();
            }
            else
            {
                x += 5;
                Console.WriteLine("x = {0}", x);
                Console.ReadKey();
            }

            int y = 7;
            if (y >= 60)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("failed");
                Console.WriteLine("you most take this again.");
            }


        }
    }
}






