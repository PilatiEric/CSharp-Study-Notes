// See https://aka.ms/new-console-template for more information


//The While Loop
//Continuously runs what's in the block statement while the condition is true
int players_number = -1;

while (players_number < 0 || players_number > 10)
{
    Console.Write("Enter a number between 0 and 10: ");
    string player_response = Console.ReadLine();
    players_number = Convert.ToInt32(player_response);
}





//The Do/While Loop
//Will first run what's in the block statement whether the condition following it
//is true or not and then checks to see if it's true before running it again

//variable didn't need number associated with it, but needed to be declared
//outside of block so it could be used not just in the block
int players_number;

do
{
    Console.Write("Enter a number between 0 and 10: ");
    string player_response = Console.ReadLine();
    players_number = Convert.ToInt32(player_response);
}
while (players_number < 0 || players_number > 10);




//The For Loop
//Repeats something a set number of times
//Always takes the form of:
// for (initialization statement; condition to evaluate; updating action)
// {
//     ...
// }

for (int for_num = 1; for_num <= 5; for_num++)
{
    Console.WriteLine(for_num);
}




//Break Out of Loops and Continue to the Next Pass
//Break statement immediately causes you to exit a loop
//Continue statement causes you to end the current pass and begin the next one

while (true)
{
    Console.Write("Think of a number and type it here: ");
    string input = Console.ReadLine();

    if (input == "quit" || input == "exit")
    {
        break;
    }
    int number = Convert.ToInt32(input);

    if (number == 12)
    {
        Console.WriteLine("I don't like this number. Pick another one.");
        continue;
    }
    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
}




//Nesting Loops

for (int first_num = 0; first_num < 10; first_num++)
{
    for (int second_num = 0; second_num < 10; second_num++)
    {
        Console.WriteLine($"{first_num} * {second_num} = {first_num * second_num}");
    }
}


int total_rows = 5;
int total_cols = 10;

for (int current_row = 1; current_row <= total_rows; current_row++)
{
    for (int current_col = 1; current_col <= total_cols; current_col++)
    {
        Console.WriteLine("*");
    }
    Console.WriteLine();
}