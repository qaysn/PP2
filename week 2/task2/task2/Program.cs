using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static bool Solve(int n) //функция, проверяющая число, если оно простое
        {
            if (n == 1) return false; //потому что 1 не простое
            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0) return false; //потому что простые числа могут делиться на 1 или они
            }
            return true; //потому что в других случаях число простое
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\g\Desktop\e.txt", FileMode.Open, FileAccess.Read); //открыть файл
            StreamReader sr = new StreamReader(fs); //read file
            int[] a = File.ReadAllText(@"C:\Users\g\Desktop\e.txt").Split(' ').Select(n => int.Parse(n)).ToArray(); //прочитать каждое число и создать массив из них

            using (StreamWriter file = new StreamWriter(@"C:\Users\g\Desktop\c.txt")) //открытие файла для вывода
            {
                foreach (int n in a) //для каждого элемента в массиве
                {
                    if (Solve(n)) //если это простое
                    {
                        file.Write(n + " "); //напишите это в нашем выходном файле
                    }
                }

            }
            string line = sr.ReadLine(); //читать выходной файл
            sr.Close(); //закрыть
            fs.Close();
        }
    }
}