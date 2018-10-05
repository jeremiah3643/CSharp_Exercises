using System;
using System.Collections.Generic;

namespace classes

{
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
}