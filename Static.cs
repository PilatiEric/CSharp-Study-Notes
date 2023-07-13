//STATIC


//Each instance of a class has it's own unique field values
//This means that a value will appear according to what the user enters
//Using the "static" keyword allows a single value to be set across all instances of the class

//Static Fields

public class Score
{
    private int Points { get; set; } = 0;
    private int Level { get; set; } = 0;
    private static int PointThreshold { get; } = 1000;
    private static int LevelThreshold { get; } = 4;

    public bool IsWorthyOfHighScoreTable()
    {
        //All variables and fields called must come from within the class
        if (Points < PointThreshold) return false;
        if (Level < LevelThreshold) return false;
        return true;
    }
}
   