using System;
using System.Collections.Generic;
using StudentExercise;

namespace StudentExercises
{
    public class Student
    {
        internal string cohortName;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slackhandle { get; set; }
        public string Cohort { get; set; }
        public List<Exercise> ExerciseList { get; set; } = new List<Exercise>();
        internal Cohort Cohor { get; set; }

        public Student(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;

        }
        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void getFullNameAddExercise(Student student)
        {
            Console.WriteLine($"Exercise List: {student.getFullName()}:");
            Console.WriteLine(" ");
            foreach(Exercise exercise in student.ExerciseList)
            {
                Console.WriteLine($"The Exercise Name: {exercise.ExerciseName}");
                Console.WriteLine($"The Language: {exercise.ExerciseType}");
                Console.WriteLine(" ");
            }
        }
    }
}