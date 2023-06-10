using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            
            while ((n >= 0) && (n <= 100))
            {
                List<int> numbers1 = new List<int>();
                List<int> numbers2 = new List<int>();
                for (int i = 0; i < n ; i++)
                {
                    numbers1.Add(int.Parse(Console.ReadLine()));
                }

                for (int j = 0; j < numbers1.Count ; j++)
                {
                    if (numbers1[j] > 0) // 0 не е нито положително число , нито отрицателно
                    {
                        numbers2.Add(numbers1[j]);
                    }
                }
                Console.WriteLine($"Average = {numbers2.Average()}");
                Console.WriteLine();

                numbers1.Sort();
                Console.WriteLine(string.Join(" ",numbers1));
                Console.WriteLine($"Min = {numbers1.Min()} на позиция -> numbers1[{0}]");
                Console.WriteLine($"Max = {numbers1.Max()} на позиция -> numbers1[{n-1}]");
                break;

                //Пробвах и така ама като е в цикъл и не изписва само крайния min или max 

                //int min = numbers1[0];
                //int max = numbers1[0];
                //int index;
                //for (index = 0; index < numbers1.Count; index++)
                //{
                //    if (numbers1[index]<min)
                //    {
                //        min=numbers1[index];
                //        Console.WriteLine($"Min = {min} na numbers1[{index}]");
                        
                //    }
                //    if (numbers1[index]>max)
                //    {
                //        max = numbers1[index];
                //        Console.WriteLine($"Max = {max} na numbers1[{index}]");

                //    }
                //}break;
            }
        }
    }
}
