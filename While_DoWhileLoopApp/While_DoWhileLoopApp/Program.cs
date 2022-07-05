using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //while Loop
            //Even Odd Number
            int number = 0;
            while (number < 10)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }

            //do while loop

            int number1 = 0;

            do
            {
                if(number1%2!=0)
                {
                    Console.WriteLine(number1);
                }
                number1++;
            }
            while (number1<20);

            Console.ReadKey();
        }
    }
}
