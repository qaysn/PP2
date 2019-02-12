using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student
    {
        public string name;
        public string id;
        public int year_of_study;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = Convert.ToString(Console.ReadLine());
            s.id = Convert.ToString(Console.ReadLine());
            s.year_of_study = int.Parse(Console.ReadLine());
            Console.Write(s.name + " " + s.id + " " + s.year_of_study + " ");
        }


    }
}