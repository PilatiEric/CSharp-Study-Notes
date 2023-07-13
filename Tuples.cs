// See https://aka.ms/new-console-template for more information


//Tuples

//TUPLE BASICS


//Tuples allow us to combine multiple types into one item

(string, int, int) score = (
    "R2-D2", 
    69420, 
    15);

//Can also be used with var
var score2 = (
    "R2-D2", 
    69420, 
    15);

//To access items in a tuples Item1, Item2, etc. are to be used
Console.WriteLine(
    $"Name: {score.Item1}  Level: {score.Item3}  Score: {score.Item2}"
    );

//As long as they have the same number of items and type order, tuples can be copied over
(string, int, int) score3 = 
    score;






//TUPLE ELEMENT NAMES


//Tuple item names can be modified by putting a new name 
(string Name, int Points, int Level) score_names = (
    "R2-D2", 
    69420, 
    15
    );
Console.WriteLine(
    $"Name: {score_names.Name}  Level: {score_names.Level}  Points: {score_names.Points}"
    );

//If an item is not assigned a name, it will keep its ItemN label
(string Name, int, int) score_names2 = (
    "R2-D2", 
    69420, 
    15
    );
Console.WriteLine(
    $"Name: {score_names2.Name}  Level: {score_names2.Item3}  Points: {score_names2.Item2}"
    );

//If using var, names are applied when the tuple is formed
var names_var = (
    Name: "R2-D2", Points: 69420, Level: 15
    );
Console.WriteLine($"Name: {names_var.Name}  Level: {names_var.Level}  Points: {names_var.Points}");






//TUPLES AND METHODS


//Tuples can be used as parameters in methods
void display_score (
    (string Name, int Points, int Level) score_meth)
{
    Console.WriteLine(
        $"Name: {score_meth.Name}  Level: {score_meth.Level}  Points: {score_meth.Points}"
        );
}

//Tuples can also be return types
(string Name, int Points, int Level) get_score() => ("R2-D2", 69420, 15);






//MORE TUPLES EXAMPLES

//Doubles
(double X, double Y) coordinates = (2.0, 4.0);

//Enumerations
//enum TileType { Grass, Water, Rock }   <= Can been found at the end of the file
var tile = (Row: 2, Column: 4, Type: TileType.Grass);

//Matrix
var matrix = (
    M11: 1, M12: 0, M13: 0, M14: 0,
    M21: 0, M22: 1, M23: 0, M24: 0,
    M31: 0, M32: 0, M33: 1, M34: 0,
    M41: 0, M42: 0, M43: 0, M44: 1
    );

//Array
//This creates a method that returns an array of tuples
(string Name, int Points, int Level)[] create_high_scores()
{
    return new (string, int, int)[3]
    {
        ("R2-D2", 69420, 15),
        ("C-3PO", 666, 88),
        ("GONK", -1, 1)
    };
}






//DECONSTRUCTING TUPLES

//All parts of a tuples can be broken up and placed in their own variables
string name;
int points;
int level;

(name, points, level) = score;
Console.WriteLine($"{name} reached level {level} with {points} points.");

//A use for this is switching the contents of two variables
double x = 4;
double y = 2;
(x, y) = (y, x);
//This is good because instead of doing this with multiple lines like this:
x = 2;
y = 4;
//it can be done with just one.






//TUPLES AND EQUALITY








enum TileType { Grass, Water, Rock }