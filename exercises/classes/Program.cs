using System;
using System.Collections.Generic;

namespace classes {

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