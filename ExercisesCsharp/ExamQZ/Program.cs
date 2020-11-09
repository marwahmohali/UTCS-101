using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int BassNumber;
            int Cons;

            int Result = 1;
            int Counter = 1;

            Console.WriteLine("enter the number");
            BassNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the scond number");
            Cons = Convert.ToInt32(Console.ReadLine());

            do
            {
                Result *= BassNumber;

                Counter++;

            } while (Counter <= Cons);


            Console.WriteLine("good {0}", Result);
            Console.ReadKey();
        }
    }
}
