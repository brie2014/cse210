public class Goals
{
    // Attributes
    int _timeGoal;
    int _exercisesGoal;

    //Methods 
    public void SetGoals()
    {
        Console.WriteLine("Let's set some goals for today.");
        Console.Write("How long, in seconds, would you like to practice today? ");
        _timeGoal = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many exercises would you like to complete today? ");
        _exercisesGoal = Convert.ToInt32(Console.ReadLine());
    }

    public void CheckGoals(int totalTime, int totalExercises)
    {
        // Check goals
        if (totalTime >= _timeGoal)
        {
            Console.WriteLine($"Congrats, you spent {totalTime} seconds practicing mindfulness and met your goal of {_timeGoal} seconds!");
        }
        else
        {
            Console.WriteLine($"Spend some more time! You only need {_timeGoal - totalTime} more seconds to meet your goal of {_timeGoal} seconds!");
        }
        if (totalExercises >= _exercisesGoal)
        {
            Console.WriteLine($"Congrats, you completed {totalExercises} exercises and met your goal of {_exercisesGoal} exercises!");
        }
        else
        {
            Console.WriteLine($"Keep practicing! You only need {_exercisesGoal - totalExercises} more exercises to meet your goal of {_exercisesGoal} exercises!");
        }
    }

}