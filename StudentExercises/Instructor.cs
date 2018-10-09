namespace StudentExercises {

    public class Instructor {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        public Instructor (string first, string last, string handle, Cohort cohort) {
            FirstName = first;
            LastName = last;
            SlackHandle = handle;

        }
        public void Tasker (Exercise exercise, Student student) {
            student.exercises.Add (exercise);

        }

    }

}