


//Null Referencesd

//A "Null" value indicates there is an abscence of anything in a variable
//This means almost any variable of any variable type may contain a null value
//string name = null;


//Null or Not?

//You may decide if a variable may contain a null value by putting a ? next to the variable type
string? name = Console.ReadLine();
//It's possible to enter a Null value in Console.ReadLine() by press Ctrl + Z


//Checking for Null
//If a null value if optional, you'll want to check for it
if (name != null)
    Console.WriteLine("The name is not null.");


//Null-Conditional Operators: ?. and ?[]
//It's important to check to see if something returns Null every step of the way
//Arrays and indexes need to be checked

Array[] _scoreManager = new Array[10];

private string? GetTopPlayerName()
{


    if (_scoreManager == null)
        return null;

    
}