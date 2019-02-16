using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void PrintInfo(FileSystemInfo fsi, int k) //создание функции, которая записывает в консоль все файлы и каталоги, которые находятся в строковом пути
        {
            string s = new string(' ', k);
            Console.WriteLine(s + fsi.Name);

            if (fsi.GetType() == typeof(DirectoryInfo)) //если мы получим информацию из папки
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos(); //массив, содержащий каталоги
                for (int i = 0; i < arr.Length; ++i) //перебежать массив
                {
                    PrintInfo(arr[i], k + 3); //выводить каждый каталог
                }
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\g\Desktop"); //метод для создания, перемещения и перечисления через каталоги
            PrintInfo(dir, 0);
        }
    }
}