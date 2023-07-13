// See https://aka.ms/new-console-template for more information

//Arrays

//Arrays hold values of only one data type and has a preset number of spaces
int[] scores = new int[10]; //This will hold only 10 ints

//New arrays of the same name can be created to create more spaces for values
//They will not contain the values from the previous array, though
scores = new int[20];


//Getting and Setting Values in Arrays
//To set a value in the array, state which space in the array the value should take up
//followed by assigning the value itself.
scores[0] = 99;
scores[1] = 95;
scores[2] = 90;

//To read the particular value you use the name of the array and the indexer operator
Console.WriteLine(scores[0]);

//Until assigned otherwise, all spots in an array will be assigned the value of 0


//Crossing Array Bounds
//C# prevents index out-of-range errors when trying to reach before or past the range of an array
int[] array_out_of_bounds = new int[5];
//array_out_of_bounds[10] = 1000;

//Can ask for length of an array
Console.WriteLine(array_out_of_bounds.Length);

//The .Length is particularly useful when the length of an array is not known
int length = Convert.ToInt32(Console.ReadLine());
int[] length_array = new int[length];

for (int index = 0; index < length_array.Length; index++)
{
    length_array[index] = 1;
}


//Indexing from the End
//You can also index starting from the back
int last_item = scores[^1];


//Ranges
//You can also make copies of sections of other arrays using ..
//The first number listed is the index to start at and the second number is the last but it's
//not included in the copy
int[] first_three_scores = scores[0..3];


//Other Ways to Create Arrays
//You can also create an array and assigns the values at the same time
//This is called collection initializer syntax
int[] another_array = new int[10] { 100, 95, 92, 90, 85, 80, 75, 70, 65, 60 };


//Foreach Loop

int[] foreach_array = new int[10];

for (int array_i = 0; array_i < foreach_array.Length; array_i++)
{
    int foreach_index = foreach_array[array_i];
    Console.WriteLine(foreach_index);
}
//The foreach loop is used specifically for iterating through an array
foreach (int foreach_index in foreach_array)
{
    Console.WriteLine(foreach_index);
}
//Downside is that you lose track of which index you are on and it runs slightly
//slower than a for loop

//THE DECLARED VARIABLE INSIDE OF THE FOREACH LOOP STATEMENT IS THE VALUE IN AN ARRAY
//AND NOT THE INDEX


//Multi-Dimensional Arrays
//These allow you to have arrays within arrays
int[,] matrix = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
Console.WriteLine(matrix[0, 1]); //Displays 2

//Array looks like this  [1 2]
//                       [3 4]
//                       [5 6]