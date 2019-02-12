using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n]; // создадим новый массив
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine()); //даем значение массиву
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");//дублирование
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();//без кей сразу закроется
        }
    }
}