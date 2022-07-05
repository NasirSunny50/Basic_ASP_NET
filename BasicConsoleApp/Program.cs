using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name:");
            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(name);
            Console.Write(age);

            
            Console.ReadKey();
        }
    }

}
