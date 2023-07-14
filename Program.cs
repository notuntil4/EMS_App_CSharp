using System;
using EMS;
using System.Collections.Generic;

namespace EMS {

    class Employee {

        private int idCounter = 0;

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
    }



    class Program {

        EmployeeDao employeeDao = new EmployeeDao();

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
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
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

        static void Main(string[] args) {
            employeeDao = new EmployeeDao();

            Console.WriteLine("Welcome to the EMS App!");

            mainMenu();


        }

    }

}

