// See https://aka.ms/new-console-template for more information

//VARIABLES

//Declaring and Assigning Variables

string name = "user";
Console.WriteLine("Hi " + name);

int numbers = 5;
int things = 10;
Console.WriteLine(numbers + things);








//Variable Types

//Integer Types
byte num = 245;
short num_short = -16_584;
int num_int = 1_624_213_725;
long num_long = -4_004_347_105_655_321_745;
sbyte num_sbyte = -119;
ushort num_ushort = 65_534;
uint num_uint = 4_107_456_845;
ulong num_ulong = 11_245_600_743_105_411_625L;
//Binary and Hexadecimal numbers are also counted as integers
//Binary numbers are base 2 (0 and 1 used)
//For Binary numbers, begin number with "0b"
int num_binary = 0b00001011;
//Hexadecimal numbers are base 16 (0-9 and A-F used)
//For Hexadecimal numbers, begin number with "0x"
int num_hexadecimal = 0xD34B1ACA;

//Text Types
//Char uses single quotations
char text_char = 'f';
//Strings use double quotations
string text_string = "Fuck off!";
//Hexadecimal Unicode numbers are counted as chars
//For Unicode numbers, begin with "\u"
char text_unicode = \0061; //This represents 'a'

//Floating-Point Types
//IF USING SCIENTIFIC NOTATION WITH float MUST PUT 'f' OR 'F' AT END OF NUMBER
float num_float = 3.62362e31f; //Same as 3.62362 x 10^31
double num_double = 5.147e297; //Same as 5.147 x 10^297
//IF USING SCIENTIFIC NOTATION WITH decimal MUST PUT 'm' OR 'M' AT END OF NUMBER
decimal num_decimal = -6.512e21m; //Same as -6.512 x 10^21

//Boolean Type
bool bool_bool = false;

//Type Inference
//Instead of specifying the variable type, you can use 'var'
var var_int = 1569854;
var var_string = "Hullo";
var var_float = 154.032158;
var var_bool = true;









//Shortcuts for Variable Assignment

/*
 * You can declare and assign a variable at the same time
 * Instead of writing the declaration and then the assignment on two lines like below
*/
int x;
x = 0;
//Combine them together to do the same thing in one line
int x = 0;

/*
 * You can declare multiple variables with the same type at the same time in one line
 * Instead of declaring them seperately like this:
 */
int a;
int b;
int c;
//Declare them all in one line by serperating them with commas
int a, b, c;

/*
 * You can assign multiple variables the same value at the same time
 * Instead of Assigning variables on seperate lines like this
 */
a = 10;
b = 10;
c = 10;
//Combine them all in one line but serperated by equal signs
a = b = c = 10;


