using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("K = ");
            int k=int.Parse(Console.ReadLine());

            Console.Write("Въведи брой числа:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers=new int[n];   
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;

                if (number == 999)
                {
                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==k)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Counter = {counter}");
        }
    }
}
