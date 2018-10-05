using System;
using System.Collections.Generic;

namespace classes {
    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a public property for holding a list of current employees
        public List<Employee> employees = new List<Employee> ();

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string NameofCompany, DateTime CompanyCreatedOn) {
            Name = NameofCompany;
            CreatedOn = CompanyCreatedOn;
        }
        public void ListEmployees () {
            foreach (Employee employee in employees) {
                Console.WriteLine ($"{employee.FirstName} " + $"{ employee.LastName} works for" + $" {this.Name}, As " + $"{employee.Title} since " + $"{employee.StartDate}");
            };
        }

    }

    public class Employee {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

    }

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.
            Company foundationsInc = new Company ("Foundations Inc", DateTime.Now);

            // Create three employees
            Employee George = new Employee () {
                FirstName = "George",
                LastName = "Atwater",
                Title = "IT Security Officer",
                StartDate = DateTime.Now
            };
            Employee Jessica = new Employee () {
                FirstName = "Jessica",
                LastName = "Hamilton",
                Title = "Human Resource Manager",
                StartDate = DateTime.Now
            };
            Employee Alexander = new Employee () {
                FirstName = "Alexander",
                LastName = "The Great",
                Title = "CTO",
                StartDate = DateTime.Now
            };

            // Assign the employees to the company
            foundationsInc.employees.Add (George);
            foundationsInc.employees.Add (Jessica);
            foundationsInc.employees.Add (Alexander);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foundationsInc.ListEmployees ();
        }
    }
}