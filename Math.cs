// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//MATH

//The Remainder Operator
//Used to divide one number by another before returning the remaining value
//int remainder = 82 % 7; //This will return the value 5



//Overflow and Roundoff Error
//Overflow errors happen when a number exceeds the data type it's been cast as
short a = 30000;
short b = 30000;
short sum = (short)(a + b);
Console.WriteLine(sum); //This results in - 5536
//Roundoff errors happen when the number of digits presented exceed the typical 
//number of digits of precision that can be calculated with the given data type
float overflow_a = 10000;
float overflow_b = 0.00001f;
float overflow_sum = overflow_a + overflow_b; //This returns 10000



//Pi and e
double pi = Math.PI;
double e = Math.E;

//Powers and Square Roots
double power = 3.0;
double power_squared = Math.Pow(power, 2);

double square_root = Math.Sqrt(power_squared);

//Absolute Value
int absolute_value = Math.Abs(-2);

//Min, Max, and Clamp
int min_max_num = 420;
int max_min_num = -69;
//Max returns the larger of two integers
int max_num = Math.Max(min_max_num, max_min_num); //Returns 420
//Min Returns the smaller of two integers
int min_num = Math.Min(min_max_num, max_min_num); //Returns -69



//MathF Class
//The same as the Math Class except it uses floats instead of doubles