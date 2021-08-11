using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(01, "Karun",6);
            Student student2 = new Student(02, "Mahesh", 8);
            Student student3 = new Student(03, "Billa", 7);
            Student student4 = new Student(04, "Pavan", 9);

            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);
            studentsTable.Add(student4.Id, student4);

            Student storedStudent1 = (Student)studentsTable[student1.Id];

            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine(temp.Id);
                Console.WriteLine(temp.Name);
                Console.WriteLine(temp.Cgpa);
            }
            Console.WriteLine(storedStudent1.Id + " " + storedStudent1.Name + " " + storedStudent1.Cgpa);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Cgpa { get; set; }

        public Student(int id, string name, float cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Cgpa = cgpa;
        }
    }
    
}
