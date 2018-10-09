using System.Collections.Generic;
namespace StudentExercises {

    public class Student {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> exercises = new List<Exercise> ();

        public Student (string first, string last, string handle, Cohort cohort) {
            FirstName = first;
            LastName = last;
            SlackHandle = handle;
        }

    }
}