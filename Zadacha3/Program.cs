using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int counterPositive = 0;
            int counterNegative = 0;
           
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
                if (numbers[i] > 0 && numbers[i] != 999)
                {
                    counterPositive++;
                }
                else if (numbers[i] < 0)
                {
                    counterNegative++;
                }
            }

            if (counterPositive > counterNegative)
            {
                Console.WriteLine("Броят на положителните числа е по-голям от броя на отрицателните!");
            }
            else if (counterNegative > counterPositive)
            {
                Console.WriteLine("Броят на положителните числа е по-малък от броя на отрицателните!");
            }
            else
            {
                Console.WriteLine("Броят на положителните числа е равен на броя на отрицателните!");
            }
        }
    }
}
