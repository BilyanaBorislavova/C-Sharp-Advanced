using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = info[0];
                decimal salary = decimal.Parse(info[1]);
                string position = info[2];
                string department = info[3];

                Employee employee = new Employee(name, salary, position, department);

                if (info.Length == 6)
                {
                    string email = info[4];
                    int age = int.Parse(info[5]);
                    employee.Email = email;
                    employee.Age = age;
                }
                else if(info.Length == 5)
                {
                    if (info[4].Contains("@"))
                    {
                        string email = info[4];
                        employee.Email = email;
                    }
                    else
                    {
                        int age = int.Parse(info[4]);
                        employee.Age = age;
                    }
                }

                list.Add(employee);
            }

            foreach (var department in list.GroupBy(a => a.Department).OrderByDescending(a => a.Average(b => b.Salary)).Take(1))
            {
                //var sort = department.Average(a => a.Salary).ToString();

                Console.WriteLine($"Highest Average Salary: {department.Key}");
                foreach (var item in department.OrderByDescending(a => a.Salary))
                {
                    Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Email} {item.Age}");
                }
            }
        }
    }
}
