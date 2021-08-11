using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO","Rony",52,200),
                new Employee("Manager" , "Danny" , 35 , 30),
                new Employee("HR" , "Venom" , 32 , 21),
                new Employee("Secretary" , "RamJi" , 25 , 20),
                new Employee("Lead Developer" , "Krazey" , 50,35),
                new Employee("Intern" , "Mocori" , 22,8),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1 , "One" },
                { 2 , "two" },
                { 3 ,"Three"}
            };

            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();

            foreach(Employee emp in employees)
            {
                employeeDictionary.Add(emp.Role, emp);
            }
            //Updating the value in the dictionary....
            string KeyToUpdate = "HR";
            string KeyToRemove = "Manager";
            if(employeeDictionary.ContainsKey(KeyToUpdate))
            {
                employeeDictionary[KeyToUpdate] = new Employee("HR", "Spider", 32, 21);
                Console.WriteLine("Employee name with Role of "+ KeyToUpdate + " Is updated");
            }else
            {
                Console.WriteLine("No employee found with this key : " + KeyToUpdate);
            }
            //Removing the value in the dictionary....
            if(employeeDictionary.ContainsKey(KeyToRemove))
            {
                employeeDictionary.Remove(KeyToRemove);
                Console.WriteLine("Employee with " + KeyToRemove +" key is removed");
            }

            for(int i = 0; i<employeeDictionary.Count;i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeeDictionary.ElementAt(i);

                //Printing the Keys in the Dictionary....
                Console.WriteLine("Key "+i + ":" + keyValuePair.Key);
                //Storing the value in the employee object....
                Employee employeeValue = keyValuePair.Value;
                //Printing the properties of the employee object....
                Console.WriteLine("Employee Name : " + employeeValue.Name);
                Console.WriteLine("Employee Role : " + employeeValue.Role);
                Console.WriteLine("Employee Age : "  + employeeValue.Age);
                Console.WriteLine("Employee Salary : " + employeeValue.Salary);
            }

            string key = "Intern";
            if(employeeDictionary.ContainsKey(key))
            {
                Employee emp1 = employeeDictionary[key];
                Console.WriteLine("Employee name is : " + emp1.Name + " Role is : " + emp1.Role + " Salary is : " + emp1.Salary);
            }
            else
            {
                Console.WriteLine("No Employee with this key -"+key);
            }

            Employee result = null;
            if(employeeDictionary.TryGetValue("CEO" , out result))
            {
                Console.WriteLine("Value Retrived!.");

                Console.WriteLine("Employee Name : " + result.Name + "\n" + "Employee Role : " + result.Role + "\n" +
                    "Employee Age : " + result.Age + "\n" + "Employee Salary : " + result.Salary);
            }
            else
            {
                Console.WriteLine("The key value does not exit");
            }
        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role , string name , int age , float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
