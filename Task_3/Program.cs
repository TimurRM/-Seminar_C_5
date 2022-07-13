using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите десятичное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int q = 0;
            int i = 0;



            int[] newArray = new int[100];

            while (number >= 1)
            {
                q = number % 2;
                newArray[i] = q;
                i++;

                number /= 2;
                Console.Write(q);
            }
            Console.Write(" -> ");

            int[] ReversArray(int[] inArray)
            {
                int[] result = new int[inArray.Length];
                for (int j = 0; j < inArray.Length; j++)
                {
                    result[j] = inArray[inArray.Length - 1 - j];
                }

                return result;
            }
            int[] reversArray = ReversArray(newArray);
            Console.WriteLine(string.Join("", reversArray));


            Console.Write("Десятичное число: ");
            int dec = Convert.ToInt32(Console.ReadLine());

            string bin = string.Empty;
            while (dec > 0)
            {
                bin = dec % 2 + bin;
                dec /= 2;
            }

            Console.WriteLine($"Двоичное число: {bin}");
            Console.Readkey();
        }
    }
}