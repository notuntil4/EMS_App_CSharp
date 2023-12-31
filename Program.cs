﻿using System;
using EMS;
using System.Collections.Generic;

namespace EMS {

    class Employee {

        private int idCounter = 1;

        private int id;
        public int Id {
            get { return id; }
        }

        private string firstName;
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }

        private DateTime startDate;
        public DateTime StartDate {
            get { return startDate; }
            set { startDate = value; }
        }

        private int salary;
        public int Salary {
            get { return salary; }
            set { salary = value; }
        }

        private string department;
        public string Department {
            get { return department; }
            set { department = value; }
        }

        public string print() {
            return "[ id = " + id + ", name = " + firstName + " " + lastName + ", department = " + department + ", startDate = " + startDate + ", salary = " + salary + " ]";
        }

        public Employee(string firstNameVal, string lastNameVal, string departmentVal, DateTime startDateVal, int salaryVal) {
            id = idCounter++;
            firstName = firstNameVal;
            lastName = lastNameVal;
            department = departmentVal;
            startDate = startDateVal;
            salary = salaryVal;
        }
    }

    class EmployeeDao {

        private List<Employee> employees;

        public EmployeeDao() {
            employees = new List<Employee>();
            employees.Add( new Employee("Foo", "Bar", "HR", new DateTime(2023, 3, 23), 50000) );
        }

        public List<Employee> getEmployees() {
            return employees;
        }

        public Employee getEmployeeById(int id) {
            
            for(int i = 0; i < employees.Count; i++) {
                if( employees[i].Id == id) {
                    return employees[i];
                }
            }

            return null;
        }
    }



    class Program {

        static EmployeeDao employeeDao = new EmployeeDao();

        static void mainMenu() {

            bool exit = false;

            while( !exit ) {
                Console.WriteLine("\n1. View Employees"
                            + "\n2. Get Employee By Id"
                            + "\n3. Add Employee"
                            + "\n4. Remove Employee"
                            + "\n5. Update Employee"
                            + "\n6. Exit"
                            );
            
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option) {
                    case 1:
                        viewEmployees();
                        break;
                    case 2:
                        viewEmployeeById();
                        break;
                    case 3:
                        addEmployee();
                        break;
                    case 4:
                        deleteEmployee();
                        break;
                    case 5:
                        updateEmployee();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

            
        }

        static void viewEmployees() {

            Console.WriteLine("\nHere are all the Employees:\n");

            foreach(Employee e in employeeDao.getEmployees()) {
                Console.WriteLine( e.print() );
            }

        }

        static void viewEmployeeById() {

            Console.WriteLine("\nEnter the id of the employee you want to view:");
        
            int id = Convert.ToInt32(Console.ReadLine());

            Employee found = employeeDao.getEmployeeById(id);  

            if(found == null) {
                Console.WriteLine("\nCould not find employee with id = " + id);
            }
            else {
                Console.WriteLine(found.print());
            }

        }

        static void addEmployee() {

            Console.WriteLine("\nEnter the first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("\nEnter the last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("\nEnter the department: ");
            string department = Console.ReadLine();

            Console.WriteLine("\nEnter the salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            
        }

        static void deleteEmployee() {

        }

        static void updateEmployee() {

        }

        static void Main(string[] args) {
            

            Console.WriteLine("Welcome to the EMS App!");

            mainMenu();


        }

    }

}

