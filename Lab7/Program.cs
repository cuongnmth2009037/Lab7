using System;

namespace Lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employeeManager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("--------Employee manager----------");
                Console.WriteLine("1. Add new staff.");
                Console.WriteLine("2. Show list of employees.");
                Console.WriteLine("3. Edit employee information.");
                Console.WriteLine("4. Delete employee information.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please enter options (1-5): ");
               var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeManager.Save();
                        break;
                    case 2:
                        employeeManager.Display();
                        break;
                    case 3:
                        employeeManager.Update();
                        break;
                    case 4:
                        employeeManager.Delete();
                        break;
                    case 5:
                        Console.WriteLine("Good bye, see you again!");
                        break;
                    default:
                        Console.WriteLine("Wrong choice, please try again!");
                        break;
                }
                Console.ReadLine();
                if (choice == 5)
                {
                    break;
                }
            }
        }
    }
}