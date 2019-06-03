using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        internal string cohortName;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Slackhandle { get; set; }
        public string CohortName { get; set; }
        public List<Exercise> ExerciseList { get; set; }

        public Student(string firstName, string lastName, String slackhandle)
        {
            FirstName = firstName;
            LastName = lastName;
            Slackhandle = slackhandle;
            ExerciseList = new List<Exercise>();

        }
    }
}