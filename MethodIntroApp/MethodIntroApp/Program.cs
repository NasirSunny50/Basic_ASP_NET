using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = substract(20, 60);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static int substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

    }
}
