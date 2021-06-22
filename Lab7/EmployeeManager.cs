using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab7
{
    public class EmployeeManager
    {
        private Dictionary<String, Employee> _List = new Dictionary<string, Employee>();

        public void Save()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter Id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter Name: ");
            var name = Console.ReadLine();
            employee.Name = name;
            Console.WriteLine("Please enter Age: ");
            var age = Console.ReadLine();
            employee.Age = Convert.ToInt32(age);
            Console.WriteLine("Please enter Salary: ");
            var salary = Console.ReadLine();
            employee.Salary = Convert.ToInt32(salary);
            _List.Add(id,employee);
        }

        public void Display()
        {
            Console.WriteLine("The list of Employee");
            foreach (var list in _List)
            {
                Console.WriteLine($"Id:{list.Key},{list.Value}"); 
            }
        }

        public void Update()
        {
            Console.WriteLine("Please enter the id to correct: ");
            var id = Console.ReadLine();
            if (_List.ContainsKey(id))
            {
                Console.WriteLine("Please enter Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Please enter Age: ");
                var age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Salary: ");
                var salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Edit successfully!");
                _List[id].Name = name;
                _List[id].Age =  age;
                _List[id].Salary = salary;
            }
            else
            {
                Console.WriteLine("Fix failure!");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Please enter the id to delete: ");
            var id = Console.ReadLine();
            if (_List.ContainsKey(id))
            {
                Console.WriteLine("Delete successfully!");
                _List.Remove(id);
            }
            else
            {
                Console.WriteLine("Delete failed!");
            }
        }
    }
    
}