// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmployeeRegisterApp
{
    // Employee class to store employees informations
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        // Method to display employee information
        public override string ToString()
        {
            return $"{FirstName} {LastName} - Salary: {Salary} sek";
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public string GetSalary()
        {
            return $"{Salary} sek";
        }
    }

    // EmployeeRegister class to manage the list of employees
    class EmployeeRegister
  {
      private List<Employee> employees;

      // Constructor to initialize an empty employee register
      public EmployeeRegister()
      {
          employees = new List<Employee>();
      }

      // Method to add an employee to the list
      public void AddEmployee(Employee employee)
      {
          employees.Add(employee);
          Console.WriteLine($"Employee {employee.GetFullName()} added successfully.");
      }

    // Method to search for an employee by name
    // Method to remove an employee from the list
    // Method to update an employee in the list

    // Method to display all employees
      public void DisplayEmployees()
          {
              if (employees.Count == 0)
              {
                  Console.WriteLine("No employees in the register.");
                  return;
              }

              Console.WriteLine("\n--- Employee Register ---\n");
              for (int i = 0; i < employees.Count; i++)
              {
                  Console.WriteLine($"{i + 1}. {employees[i]}");
              }
              Console.WriteLine("\n------------------------\n");
          }
      }

  // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegister register = new EmployeeRegister();

            while (true)
            {
              // Display menu options
              Console.WriteLine("\n--- Welcome to Employee Register App ---");
              Console.WriteLine("\nChoose an option:\n");
              Console.WriteLine("1. Display Employees");
              //Console.WriteLine("2. Search Employee");
              Console.WriteLine("2. Add Employee");
              //Console.WriteLine("3. Remove Employee");
              //Console.WriteLine("4. Update Employee");
              Console.WriteLine("3. Exit");
              Console.Write("\nEnter your choice: ");

              // Get and validate user input

              string? choice = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(choice))
              {
                  Console.WriteLine("Invalid input. Please try again.");
                  continue;
              }


                switch (choice)
                {
                    case "1":
                        register.DisplayEmployees();
                        break;

                    /*case "2":
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();
                        Employee foundEmployee = register.SearchEmployee(name);
                        if (foundEmployee != null)
                        {
                            Console.WriteLine($"Employee found: {foundEmployee}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        break;
                    */

                    case "2":
                        Console.Write("Enter employee first name: ");
                        string? firstName = Console.ReadLine();
                        Console.Write("Enter employee last name: ");
                        string? lastName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                        {
                            Console.WriteLine("Invalid name input. Please try again.");
                            continue;
                        }

                        Console.Write("Enter employee salary: ");
                        string? salaryInput = Console.ReadLine();
                        // Validate salary input
                        if (double.TryParse(salaryInput, out double salary))
                        {
                            Employee newEmployee = new Employee(firstName, lastName, salary);
                            register.AddEmployee(newEmployee);
                        }
                        else
                        {
                            Console.WriteLine("Invalid salary input. Please enter a number.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nThanks for using the Employee Register App!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
