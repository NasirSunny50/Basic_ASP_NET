using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[5];

            ////populate the array

            //for(int i=0; i<num.Length; i++)
            //{
            //    String userInputText = Console.ReadLine();
            //    int userInput = Convert.ToInt32(userInputText);

            //    num[i] = userInput;
            //}

            ////sum the array values

            //int result = 0;

            //for (int i = 0; i < num.Length; i++)
            //{
            //    int num1 = num[i];

            //    result = result + num1;

            //}

            int[] values = new[] { 1, 5, 3, 6, 8, 9 };

            Array.Sort(values);

            for(int i=0; i<values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.ReadKey();
        }
    }
}
