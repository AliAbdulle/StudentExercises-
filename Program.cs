using System;
using System.Collections.Generic;
using StudentExercise;

namespace StudentExercises
{
    class Program
    {
        private static IEnumerable<Exercise> exercise;
        private static IEnumerable<Student> students;

        static void Main(string[] args)
        {
            // create 4, or more exercise
            Exercise classExercise = new Exercise("Module  and condition ", "JavaScript", 1);
            Exercise dictionaryExercise = new Exercise("Dictionary List", "C#", 2);
            Exercise reactExercise = new Exercise("Componants", "Reacr", 3);
            Exercise capstone = new Exercise("projects ", "Java", 4);
            Exercise jsonServer = new Exercise("Store data ", "JavaScript", 5);
            Exercise journalEntries = new Exercise("Daily write", "C#", 6);
            Exercise sylyingSheet = new Exercise("Componants", "Reacr", 7);
            Exercise documentsModel = new Exercise("Would check ", "Java", 8);


            // create 3 or more cohort
            Cohort c31 = new Cohort("Cohort 31", 31);
            Cohort c30 = new Cohort("Cohort 30", 30);
            Cohort c32 = new Cohort("Cohort 32", 32);

            //create 4 or more Students and assign them  to 1 assignment


            Student Tome = new Student("Tom", "Hall", 1);
            Student Dek = new Student("Dek", "Abdi", 2);
            Student Jameka = new Student("Jameka", "Echols", 3);
            Student Ali = new Student("Ali", "Abdulle", 4);

            // slack handle
            Ali.Slackhandle = "aliAbdule";
            Tome.Slackhandle = "tomeHall";
            Jameka.Slackhandle = "jamekaEchols";
            Dek.Slackhandle = "dekAbdi";


            //add to cohort
            Ali.Cohort = c31;
            Tome.Cohor = c30;
            Jameka.Cohor = c32;
            Dek.Cohor = c31;

            //create instructors

            Instructor Jisi = new Instructor("Jisi", "David", "Teacher", 1);
            Instructor Andy = new Instructor("Andy", "Collin", "Play Book", 2);
            Instructor Leah = new Instructor("Leah", "Hoefling", "Correction", 3);

            //slack contact
            Leah.SlackHandle = "leahHoefling";
            Andy.SlackHandle = "andyCollin";
            Jisi.SlackHandle = "jisiDavid";

            // Have each Student assign 2 exercises to each student
            Jisi.AssignExercise(Dek, classExercise);
            Jisi.AssignExercise(Dek, dictionaryExercise);
            Andy.AssignExercise(Ali, capstone);
            Andy.AssignExercise(Ali, jsonServer);
            Leah.AssignExercise(Jameka, reactExercise);
            Leah.AssignExercise(Jameka, documentsModel);
            Jisi.AssignExercise(Tome, dictionaryExercise);
            Andy.AssignExercise(Tome, journalEntries);

            //create list of student
            List<Student> studentList = new List<Student>()
            {
                Ali, Dek, Tome, Jameka
            };
            //create list of exercise
            List<Exercise> exerciseList = new List<Exercise>()
            {
                documentsModel,journalEntries,documentsModel,reactExercise,
                jsonServer,capstone, classExercise, dictionaryExercise

            };

            foreach (Student student in students)
            {
                student.getFullNameAddExercise(student);
                Console.WriteLine("-----------------");

                foreach (Exercise exercise in exercise)
                {
                    exercise.ListStudentOnExercise(exercise);
                    Console.WriteLine("-----------------");
                }
            }
        }

    }
}

