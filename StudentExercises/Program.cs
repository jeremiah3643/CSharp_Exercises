using System;
using System.Collections.Generic;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {

            Exercise exercise1 = new Exercise ("exercise1", "JavaScript");
            Exercise exercise2 = new Exercise ("exercise2", "CSharp");
            Exercise exercise3 = new Exercise ("exercise3", "Python");
            Exercise exercise4 = new Exercise ("exercise4", "HTML");

            Cohort Cohort27 = new Cohort ("Cohort 27");
            Cohort Cohort5 = new Cohort ("Cohort 5");
            Cohort Cohort21 = new Cohort ("Cohort 21");

            Student Jeremiah = new Student ("Jeremiah", "Pritchard", "@Jeremiah", Cohort27);
            Student George = new Student ("George", "Costanza", "@George", Cohort5);
            Student Clarice = new Student ("Clarice", "Hamilton", "@Clarice", Cohort21);

            Instructor Alex = new Instructor ("Alex", "Barker", "@Alex", Cohort27);
            Instructor Jessica = new Instructor ("Jessica", "Sanchez", "@Jessica", Cohort5);
            Instructor Ashley = new Instructor ("Ashley", "Towers", "@Ashley", Cohort21);

            Alex.Tasker (exercise1, Jeremiah);
            Alex.Tasker (exercise2, Jeremiah);
            Jessica.Tasker (exercise3, George);
            Jessica.Tasker (exercise1, George);
            Ashley.Tasker (exercise4, Clarice);
            Ashley.Tasker (exercise2, Clarice);

            List<Student> students = new List<Student> () {
                Jeremiah,
                George,
                Clarice
            };
            List<Exercise> exercises = new List<Exercise> () {
                exercise1,
                exercise2,
                exercise3,
                exercise4
            };

            foreach (Exercise exercise in exercises) {
                foreach (Student student in students) {
                    foreach (Exercise taco in exercises) {
                        if (exercise == taco)
                            Console.WriteLine ($"{exercise.ExerciseName} " + "is being worked on by" + $" {student.FirstName} {student.LastName}");
                    };

                }
            };
     
        }
    }
}