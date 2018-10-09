namespace StudentExercises {

    public class Exercise {
        public string ExerciseName { get; set; }
        public string ExerciseLanguage { get; set; }
        public Exercise (string name, string language) {
            ExerciseName = name;
            ExerciseLanguage = language;
        }

    }

}