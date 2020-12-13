using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex02_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list_e = new List<Employee>();
            Employee newEmployee;

            //Pergunta quantos funcionários serão registrados
            Console.Write("How many employees will be registered? ");
            int numEmployeesReg = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numEmployeesReg; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                newEmployee = new Employee(id, name, salary);
                list_e.Add(newEmployee);
                // ou list_e.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int idSelect = int.Parse(Console.ReadLine());

            Employee employee_found = list_e.Find(x => x.Id == idSelect);
            if (employee_found != null)
            {
                Console.Write("Enter the percentage: ");
                double raisePerc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee_found.SalaryRaise(raisePerc);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee obj in list_e)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
