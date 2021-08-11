using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Tom", 7.2f);
            students[1] = new Student(2, "Mercy", 6.2f);
            students[2] = new Student(3, "Rony", 8.0f);
            students[3] = new Student(1, "Rock", 6.7f);
            students[4] = new Student(5, "Thor", 9.5f);

            foreach(Student s in students)
            {
                if(!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine(s.Id + " " + s.Name);
                }
                else
                {
                    Console.WriteLine("Sorry The Same Id is already taken by another student");
                }
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Cgpa { get; set; }

        public Student(int id,string name,float cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Cgpa = cgpa;
        }
    }
}
