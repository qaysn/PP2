using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)

            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int cnt = 0;
            bool qwe = false;   //  если qwe  не prime то его флаг станет true , и мы выведем те члены массива
                                 //у кторых флаг false

            for(int i = 0; i < n; i++)
            {
                qwe = false;
                if (a[i] <= 1) continue;
                else
                    for (int j = 2; j < a[i]; j++)
                       if (a[i] % j == 0) qwe = true;
                if (qwe == false) cnt++;
            }




            Console.WriteLine(cnt);//Cnt это количество простых чисел
            for (int i = 0; i < n; i++)
            {
                qwe = false;
                if (a[i] <= 1) continue;
                for (int j = 2; j < a[i]; j++)
                    if (a[i] % j == 0) qwe = true;
                if (qwe == false) Console.Write(a[i] + " "); //выводим все prime цифры по строку
            }
            Console.ReadKey();
        }
    }
}
