// See https://aka.ms/new-console-template for more information



//CLASSES

// <-- Main method goes here

//This is just one instance of the class
Score best = new Score();

best.name = "R2-D2";
best.points = 69420;
best.level = 15;

if (best.EarnedStar())
{
    Console.WriteLine("You earned a star!");
}

//There can be multiple instances
Score a = new Score();
a.name = "R2-D2";
a.points = 12420;
a.level = 15;

Score b = new Score();
b.name = "C-3PO";
b.points = 8543;
b.level = 8;

if (a.EarnedStar())
{
    Console.WriteLine($"{a.name} earned a star!");
}

if (b.EarnedStar())
{
    Console.WriteLine($"{b.name} earned a star!");
}

class Score
{
    //These are not the same as local variables
    //These are called "field" or "instance variables"which are created inside an object's memory on the heap
    public string name/* = "Unknown" */; //Field can be initialized at the same time they are declared like here
    public int points/* = 0 */;
    public int level/* = 1 */;

    //This is a constructor                                                                                                                      
    //It's job is to get any new instances into a legitimate starting state
    public Score()
    {
        name = "Unknown";
        points = 0;
        level = 1;
    }

    //Constructors can also have parameters
    //There can also be multiple constructors as long as the parameters differ in variable type or number
    public Score(string name, int points, int level)
    {
        //Using this keyword allows you top reuse variable names by refering to the object you are currently in
        this.name = name;
        this.points = points;
        this.level = level;
    }



    //Unlike tuples, classes can have methods
    public bool EarnedStar() => (points / level) > 1000;
} 

// <-- Other classes and enumerations can go here