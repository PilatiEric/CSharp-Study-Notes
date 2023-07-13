// See https://aka.ms/new-console-template for more information

//Console Class

//Console.Write method
//The Write method does the same thing as the WriteLine method
//without jumping to the next line
Console.Write("What is your name?");
string user_name = Console.ReadLine();




//Console.ReadKey method
//The ReadKey method is the "Press any key to continue" method that gets
//a single key input from the user
Console.WriteLine("Press any key to continue");
Console.ReadKey();




//Formatting
//Formatting allows you to change how information is displayed
//Math.PI will display "3.141592653589793"
Console.WriteLine($"{Math.PI:0.000}"); //This tells it to round up to 3 decimal places
                                       //and displays "3.142"

//Each 0 indicates that you want a number to be there even if it's not
//strictly necessary
Console.WriteLine($"{42:000.000}"); //Displays "042.000"

//Using # instead of 0 will accomplish the same thing, but will not leave insignificant
//0's like a a leading or trailing 0
Console.WriteLine($"{42:##.###}"); //Displays "42"
Console.WriteLine($"{42.1234:#.##}"); //Displays "42.12"

//The # symbol and 0 can also be used at the same time
Console.WriteLine($"{42:000.####}"); //Displays "042"

//Can use % symbol to make a number be represented as a percentage
float current_health = 4;
float max_health = 9;
Console.WriteLine($"{current_health / max_health: 0.0%}"); //Displays "44.4%"