using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSalaryCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            List<EmployeePosition> positions = new()
            {
                new EmployeePosition("JuniorDeveloper", 1000, 5),
                new EmployeePosition("Developer", 2000, 10),
                new EmployeePosition("SeniorDeveloper", 2500, 12),
                new EmployeePosition("Architect", 3500, 20),
            };

            List<Employee> employees = new List<Employee>();

            string command = "";

            Console.WriteLine("Welcome! ");


            while (command != "Exit")
            {
                command = Console.ReadLine();

                if (command.StartsWith("Add"))
                {
                    string[] inputs = command.Split(" ");
                    string name = inputs[1];
                    string surname = inputs[2];
                    string position = inputs[3];
                    int experience = Int32.Parse(inputs[4]);

                    EmployeePosition positionsObj = positions.FirstOrDefault(p => p.PositionName == position);

                    employees.Add(new Employee(name, surname, positionsObj, experience));


                    Console.WriteLine("Added successfull!");

                    //foreach (Employee employee in employees)
                    //{

                    //Console.WriteLine(employee.Name + " " +  employee.Surname);

                    //}

                }
                if (command.StartsWith("Show"))
                {
                    string[] inputs = command.Split(" ");
                    string name = inputs[1];
                    string surname = inputs[2];
                    Employee employeeName = employees.FirstOrDefault(e => e.Name == name);
                    //Employee employeeSurname = employees.FirstOrDefault(e => e.Surname == name);
                    Console.WriteLine(employeeName.GetSalary());

                }
                if (command.StartsWith("List"))
                {
                    foreach (Employee employee in employees)
                    {

                        Console.WriteLine(employee.Name + " " + employee.Surname + " " + employee.Position);

                    }

                }


            }
        }
    }
}
