﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("\n\n");
            Console.Write("Display the first 10 natural numbers:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("The first 10 natural number are:");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n\n");

        }
    }
}
