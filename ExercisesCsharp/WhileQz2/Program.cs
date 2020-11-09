using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileQz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int BassNumber;
            int Cons;
            int Counter = 1;
            int Result = 1;


            Console.WriteLine("enter the number");
            BassNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the scond number");
            Cons = Convert.ToInt32(Console.ReadLine());

            while (Counter <= Cons)
            {
                Result *= BassNumber;
                Counter++;
                
            }

         
           

            Console.WriteLine("good {0}", Result);
            Console.ReadKey();
        }
    }
}
