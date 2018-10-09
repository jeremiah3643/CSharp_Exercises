using System.Collections.Generic;
namespace StudentExercises {

    public class Cohort {
        public string CohortName { get; set; }
        public List<Student> students = new List<Student> ();
        public List<Instructor> instructors = new List<Instructor> ();

        public Cohort (string name) {
            CohortName = name;
        }

    }
}