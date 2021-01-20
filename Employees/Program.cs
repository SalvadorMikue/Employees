using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Entities;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i=1; i<=n; i++)
            
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 'y')
                {
                    Console.Write("Additional charge:");
                    double additionalcharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalcharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour)); 
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENT:"); 
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + "_ $" + emp.Payment());
            }

        }
        
    }
}
