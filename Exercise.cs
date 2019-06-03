using System;
namespace StudentExercises{

public class Exercise {
    public Exercise(string exerciseName, string exerciseType)
    {
        ExerciseName = exerciseName;
        ExerciseType = exerciseType;

    }
    public string ExerciseName {get; set;}
    public string ExerciseType {get; set;}
}
}