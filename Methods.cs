// See https://aka.ms/new-console-template for more information

//Methods
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

void count_to_ten() //Void is the return type; it returns nothing
{
    for (int current = 1; current <= 10; current++)
    {
        Console.WriteLine(current);
    }
}




//Calling a Method
//All that's needed to call the method is the method name followed by ();
count_to_ten();




//Methods Get Their Own Variables
//Like in loops and if-then statements, variables used inside methods or functions
//can't be seen or used inside of other methods or functions
void count_to_twenty()
{
    for (int current = 1; current <= 10; current++)
    {
        Console.WriteLine(current);
    }//Current is able to be used here and 
}                                                   //count_to_ten at the same time

//Methods or variables created inside of the Main method can be used in other methods or functions
string text_thing = Console.ReadLine();

void display_text()
{
    Console.WriteLine(text_thing); //DANGER!!
}
//Using a variable from outside of the method or function has its place but is rare
//Be careful




//Passing Data to a Method
//This allows certain predesignated information (that might change) to be used inside the method
void count_that_shit(int number_to_count /*This is the parameter*/)
{
    for (int current = 1; current < number_to_count; current++)
    {
        Console.WriteLine(current);
    }
}

//When calling, designate what specific information should be used
count_that_shit(10);
count_that_shit(20);




//Multiple Parameters
void count_between(int start, int end)
{
    for (int current = start; current <= end; current++)
    {
        Console.WriteLine(current);
    }
}

count_between(10, 82);




//Returning a Value from a Method
int read_number()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Write("How high should I count? ");
int chosen_number = read_number();
count_that_shit(chosen_number);

void count_more_shit(int number_to_count_to)
{
    for (int current = 1; current <= number_to_count_to; current++)
    {
        Console.WriteLine(current);
    }
}




//Returning Early
//Return may be used before the last line
//This will cause it to automatically exit the method, though
//IMPORTANT!!! Keep in mind that you MUST return the value given when creating the method

/// <summary>
/// Asks the user for their name and returns the name provided. Will repeat when a void value or space is entered.
/// </summary>
string get_user_name()
{
    while (true)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        if (name != "" && name != " ") //Empty String
        {
            return name;
        } 
        Console.WriteLine("Let's try that again. Put a name this time, dumbass.");
    }
}

get_user_name();

//In a method that returns type void, you can end it early by just using return
void count_all_the_shit(int number_to_count_to)
{
    if (number_to_count_to < 1)
    {
        return;
    }
    for (int index = 1; index <= number_to_count_to; index++)
    {
        Console.WriteLine(index);
    }
}




//Multiple Return Values
//Methods CANNOT return multiple things at the same time




//Method Overloading
//Multiple methods can have the same name as long as their parameter lists are different
//Console.WriteLine(); is a great example of this since you can have multiple types used 




//Simple Methods with Expressions
//If a method can be represented with a single expression, it can be written on one line
int double_and_add_one(int value) => value * 2 + 1;

//If it requires a loop or if-then statement and needs multiple lines, a block body
//must be used




//XML Documentation Comments
//When creating methods, special comments can be written that describe the function of the
//method. This allowed Visual Studio to see the comments and show someone needing a description
//of the method.
//To start, you must be three forward slashes (/)

/// <summary>
/// Counts to the given number, starting at 1 and including the number provided.
/// </summary>
void count_crazy_shit (int number_to_count_to)
{
    for (int index = 1; index <= number_to_count_to; index++)
    {
        Console.WriteLine(index);
    }
}

//The Basics of Recursion
//Recursion uses a method within the same method to achieve results a loop might be used for
//ALWAYS ENSURE THERE'S A BASE CASE SO THE METHOD WILL END AT SOME POINT
int factorial(int number)
{
    if (number == 1)
    {
        return 1;
    }
    return number * factorial(number - 1);
}