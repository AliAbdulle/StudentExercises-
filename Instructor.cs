using System;
using StudentExercise;

namespace StudentExercises
{
    public class Instructor
    {
        private string v1;
        private string v2;
        private Cohort cohort1;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public StudentExercise.Cohort CohortName { get; set; }

        public void AssignStudents(StudentExercise.Cohort cohort, Exercise exercise)
        {
            foreach (Student student in cohort.studentList)
            {
                student.ExerciseList.Add(exercise);
            }
        }
        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohortName)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            CohortName = cohortName;
        }

        public Instructor(string v1, string v2, Cohort cohort1)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.cohort1 = cohort1;
        }
    }

}