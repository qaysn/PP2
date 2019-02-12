using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//int parse преобразует строка на целое число
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)// если j всегда будет меньше или равен  i то нижняя половина массива 
                    Console.Write("[*]");// заполняется с [*];
                Console.WriteLine();
            }Console.ReadKey();
        }
    }
}