using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseForLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Even Odd Detection
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            //print Even or Odd     

            for(int i =0; i<number; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
