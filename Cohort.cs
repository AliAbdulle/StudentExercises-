
using System.Collections.Generic;
using StudentExercises;

namespace  StudentExercise
{
    public class Cohort
    {
        internal IEnumerable<Student> studentList;

        public string CohortName {get; set;}
        public List<Student>StudentList{get; set;}
        public List<Instructor>InstructorList{get; set;}

        public Cohort(){
            StudentList = new List<Student>();
            InstructorList = new List<Instructor>(); 
        }

    }
}