using System;
using System.Collections.Generic;
using StudentExercise;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 4, or more exercise
            Exercise exercise1 = new Exercise("Exercise 1 ", "JavaScript");
            Exercise exercise2 = new Exercise("Exercise 2 ", "React");
            Exercise exercise3 = new Exercise("Exercise 1 ", "C#");
            Exercise exercise4 = new Exercise("Exercise 1 ", "Java");

            // create 3 or more cohort
            StudentExercise.Cohort Cohort1 = new StudentExercise.Cohort();
            Cohort1.CohortName = "Cohort1";
            Cohort Cohort2 = new Cohort();
            Cohort2.CohortName = "Cohort2";
            Cohort Cohort3 = new Cohort();
            Cohort3.CohortName = "Cohort3";

            //create 4 or more Students and assign them  to 1 assignment
            Student David = new  Student("David", "Malley", "@lonrunmygame");
            David.CohortName = "31";
            Cohort1.StudentList.Add(David);

            Student Tome = new  Student("Tom", "Hall", "@makefeelright");
            Tome.CohortName = "32";
            Cohort2.StudentList.Add(Tome);
            
            Student Dek = new  Student("Dek", "Ali", "@freindmoreJeck");
            Dek.CohortName = "33";
            Cohort3.StudentList.Add(Dek);
           
            Student Fred = new  Student("Fred", "Worker", "@techkimlong");
            Fred.cohortName = "30";
            Cohort2.StudentList.Add(Fred);

            //create 3, or more , Instructor and assign them to one of the cohorts
            Instructor Andy = new Instructor("Andy", "Collin", Cohort1);
            Cohort1.InstructorList.Add(Andy);
            
            Instructor Jisi = new Instructor("Jisi", "David", Cohort1);
            Cohort2.InstructorList.Add(Jisi);
            
            Instructor Leah = new Instructor("Leah", "Gwin", Cohort1);
            Cohort3.InstructorList.Add(Leah);

            // Have each Student assign 2 exercises to each student
            Jisi.AssignStudents(Cohort1, exercise2);
            Jisi.AssignStudents(Cohort1, exercise1);
            Andy.AssignStudents(Cohort2, exercise1);
            Andy.AssignStudents(Cohort2, exercise3);
            Leah.AssignStudents(Cohort1, exercise2);
            Leah.AssignStudents(Cohort3, exercise4);

            List<Cohort> CohortList = new List<Cohort>()
            {
                Jisi.CohortName,
                Andy.CohortName,
                Leah.CohortName
            };
            List<Student> StudentList = new List<Student>();
            List<Exercise> ExerciseList = new List<Exercise>();

            foreach(Cohort cohortName in CohortList)
            {
                foreach(Student student in cohortName.StudentList)
                {
                StudentList.Add(student);
                foreach(Exercise exercise in student.ExerciseList)
                {
                    ExerciseList.Add(exercise);
                    
                }
                }
            }

        }
    }
}
