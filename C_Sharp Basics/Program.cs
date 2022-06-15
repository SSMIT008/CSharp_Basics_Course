// C# BASICS. Short Learning File 


// Simple Program

Console.WriteLine("Please, type your name: ");
string? name = (Console.ReadLine());
Console.WriteLine($"Hello, {name}");
Console.WriteLine("Welcome to C#");


/*
 * Variables
 */


string name_1;
name_1 = "Stan";
string name_2 = "Sam";
name_2 = "Kate";
Console.WriteLine(name_1);
Console.WriteLine(name_2);


// Constant Variables - define at the begining. we cannot change such type of variables. Value should be assigned to const prior compilation;

const string NAME = "Stan";
const string NAME_2; //error highlighted, because const required a value to be provided;
const string NAME_3 = "Stan";
NAME_3 = "Sam"; //error highlighted, beacause we cannot change the const value;


/* 
 * Literals - Literals represent values, that we CANNOT change (sometimes called constants). 
 * Literals can be passed to variables as a value. 
 * Literals are boolean, integer, real, character, and string. 
 * And a single literal represents the null keyword.
 */


// Logical literals

Console.WriteLine(true);
Console.WriteLine(false);

// Integer literals

Console.WriteLine(1);               // decimal form
Console.WriteLine(-255);           // decimal form
Console.WriteLine(1000);          // decimal form

Console.WriteLine(0b11);        // 3 Binary form
Console.WriteLine(0b1011);     // 11 Binary form
Console.WriteLine(0b100001);  // 33 Binary form

Console.WriteLine(0x0A);    // 10 hexadecimal form     
Console.WriteLine(0xFF);   // 255 hexadecimal form
Console.WriteLine(0xA1);  // 161 hexadecimal form

// Real literals

Console.WriteLine(0.14);        // fractional numbers 
Console.WriteLine(-1.105);     // fractional numbers
Console.WriteLine(100.881);   // fractional numbers

Console.WriteLine(3.2e3);   // exponential form MEp, where M is the mantissa, E is the exponent, which actually means "*10^" (multiply by ten to the power) = equals 3.2 * 10<sup>3</sup> = 3200
Console.WriteLine(1.2E-1); // exponential form MEp, where M is the mantissa, E is the exponent, which actually means "*10^" (multiply by ten to the power) = equals 1.2 * 10<sup>-1</sup> = 0.12

// Character literals

Console.WriteLine('A');
Console.WriteLine('2');
Console.WriteLine('T');

// Character literals - Escape sequences

Console.WriteLine('\n');    // new line
Console.WriteLine('\t');   // tab

// also for using hexadecimal ASCII codes, see table at: https://www.asciitable.com/

Console.WriteLine('\x78');    // x
Console.WriteLine('\x5A');    // Z

// also for using Unicode codes, see table at:https://unicode-table.com/en/

Console.WriteLine('\u0420');    // Р
Console.WriteLine('\u0421');    // С

//String literals

Console.WriteLine("Hello World! \nMy name is Stan!\nI am the best C# software developer in the whole \"World\"");

// null - represents a reference that does not point to any object. That is, in fact, the absence of value


/*
 * Data types
 */


// bool - stores the value true or false (boolean literals). Represented by the system type System.Boolean

bool alive = true;
bool isDead = false;

// byte - stores an integer from 0 to 255 and occupies 1 byte. Represented by the system type System.Byte

byte bit1 = 0;
byte bit2 = 255;

// sbyte - stores an integer from -128 to 127 and occupies 1 byte. Represented by the system type System.SByte

sbyte sbit1 = -128;
sbyte sbit2 = 127;

// short - stores an integer from -32768 to 32767 and occupies 2 bytes. Represented by the system type System.Int16

short s1 = -32768;
short s2 = 32767;

// ushort - stores an integer from 0 to 65535 and occupies 2 bytes. Represented by the system type System.UInt16

ushort us1 = 0;
ushort us2 = 65535;

// int - stores an integer from -2147483648 to 2147483647 and takes 4 bytes. Represented by the System.Int32 system type. All integer literals represent values of type int by default

int i1 = -2147483648;
int i2 = 2147483647;

// uint -  stores an integer from 0 to 4294967295 and occupies 4 bytes. Represented by the system type System.UInt32

uint ui1 = 0;
uint ui2 = 4294967295;

// long - stores an integer from -9 223 372 036 854 775 808 to 9 223 372 036 854 775 807 and occupies 8 bytes. Represented by the system type System.Int64

long l1 = -9223372036854775808;
long l2 = 9223372036854775807;

// ulong - stores an integer from 0 to 18446744073709551615 and takes 8 bytes. Represented by the system type System.UInt64

ulong ul1 = 0;
ulong ul2 = 18446744073709551615;
ulong ul3 = 0b101;
ulong ul4 = 0xFF;

// float - stores a floating point number from -3.4*10^38 to 3.4*10^38 and takes 4 bytes. Represented by the system type System.Single

float f1 = -3.4E38f;
float f2 = 3.4E38f;

// double - stores a floating point number from ±5.0*10^-324 to ±1.7*10^308 and occupies 8 bytes. Represented by the system type System.Double

double d1 = -5.0E-324;
double d2 = 1.7e308;

// decimal - stores a decimal fractional number. If used without a decimal point, it has a value of ±1.0*10^-28 to ±7.9228*10^28, can store 28 decimal places, and occupies 16 bytes. Represented by the system type System.Decimal

decimal dec1 = -1.0E-28m;
decimal dec2 = 7.9228E28m;

// char - stores a single Unicode character and occupies 2 bytes. Represented by the System.Char system type. Character literals correspond to this type

char c1 = 'a';
char c2 = 'A';
char b = '\x5A';      // Z
char c = '\u0420';   // P

// string - stores a set of Unicode characters. Represented by the System.String system type. This type corresponds to string literals

string str1 = "Stan";
string str2 = "Sam";

// object - can store a value of any data type and takes up 4 bytes on a 32-bit platform and 8 bytes on a 64-bit platform. Represented by the System.Object system type, which is the base type for all other .NET types and classes

object o1 = null;
object o2 = 3.14;
object o3 = -100;
object o4 = "Achilles Games";
object o5 = 'A';

// Examples:

string name2 = "Stan Smit";
string job_title = "Senior Developer";
string company = "Microsoft";
int age = 25;
float salary = 1000000.1f;
Console.WriteLine($"Name: {name2}"); // interpolation: a $ sign is placed before the string and after that we can enter variable values into the string in curly braces
Console.WriteLine($"Job Title: {job_title}");
Console.WriteLine($"Company: {company}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Salary: {salary}");

// Suffixes - all real literals (fractional numbers) are treated as double values. And to indicate that a fractional number represents a float type or a decimal type, you need to add a suffix to the literal: F / f - for float and M / m - for decimal

float f3 = -100.1F;
float f4 = 100.714f;
decimal dec3 = -1.1m;
decimal dec4 = 100.8M;

// all integer literals are treated as values of type int. To explicitly indicate that an integer literal represents a value of type uint, use the suffix U/u, for type long use the suffix L/l, and for type ulong use the suffix UL/ul

uint ui5 = 1005U;
long l3 = -9223372036854775808L;
ulong ul = 30UL;

// Using System Types - Above, when listing all the basic data types, a system type was mentioned for each. Because the name of the built-in type is essentially a shorthand for the system type

int i3 = 5;                  // the same
System.Int32 i4 = 5;        // the same


/* Implicit typing - the var keyword is used. 
 * Then, during compilation, the compiler itself infers the data type based on the assigned value. 
 * Since by default all integer values are treated as values of type int, the variable v1 will end up being of type int. 
 * Similarly, the variable v3 is assigned a string, so this variable will be of type string */

var v1 = 4;
var v2 = -5.1;
var v3 = "Hello!";

// Implicit typing restrictions:

// 1. We cannot first declare an implicitly typed variable and then initialize

int i5; // this code is working
i5 = 20;

var v4; // this code is NOT working
v4 = 20;

// 2. We cannot specify null as the value of an implicitly typed variable:

var v5 = null; // this code is NOT working


/* 
 * Console Input/Output
 */


//Input

// Print to the console in one line the values of several variables at once (interpolation)

string name3 = "Stan Smit";
string job_title2 = "Senior Developer";
string company2 = "Microsoft";
int age2 = 25;
float salary2 = 1000000.1f;
Console.WriteLine($"Name: {name3} \nJob Title: {job_title2} \nCompany: {company2} \nAge: {age2} \nSalary: {salary2}");

/* Different method. {0}, {1}, {2} - These are placeholders, instead of which some values will be substituted when the string is output to the console. 
 * Substituted values are specified after the string separated by commas. The order of such placeholders is important. Numeration starts from zero */

string name4 = "Stan Smit";
string job_title3 = "Senior Developer";
string company3 = "Microsoft";
int age3 = 25;
float salary3 = 1000000.1f;
Console.WriteLine("Name: {0} \nJob Title: {1} \nCompany: {2} \nAge: {3} \nSalary: {4}", name4, job_title3, company3, age3, salary3); // Please note: NO $ sign before " for this method

// Console.Write() - it works exactly the same as Console.WriteLine(), except that it does not add a line break, meaning that subsequent console output will appear on the same line

// Output

/* Console.ReadLine() - it can read information from the console as a string only. 
 * A possible situation when the Console.ReadLine method does not have rows available for reading, that is, when it has nothing to read, it returns null. 
 * That is, roughly speaking, the absence of a value. Question mark ? indicates that the variable can also store the value null, that is, in fact, have no value */

Console.WriteLine("Please enter your name: ");
string? name5 = Console.ReadLine(); // Question mark ? indicates that the variable CAN also store the value NULL
Console.WriteLine($"Hello {name5}");


/* Convert different values to int, double, etc. Some of these methods:
 * Convert.ToInt32() - convert to type int
 * Convert.ToDouble() - convert to type double
 * Convert.ToDecimal() - convert to type decimal */

Console.Write("Enter your name: ");
string? name6 = Console.ReadLine();
Console.Write("Enter your age: ");
int age4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your weight: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your salary: ");
decimal salary4 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Name: {name6}, Age: {age4}, Weight: {weight}, Salary: {salary4}");


/* 
 * C# arithmetic operations
 */


// BINARY arithmetic operations:

// (+) Addition - the operation of adding two numbers:

int x1 = 10;
int y1 = x1 + 11; // 21

// (-) Substraction - the operation of subtracting two numbers:

int x2 = 30;
int y2 = x2 - 5; // 25

// (*) Multiplication - the operation of multiplying two numbers:

int x3 = 2;
int y3 = 10 * x3; // 20

// (/) Division - the operation of dividing two numbers:

int x4 = 10;
int y4 = x4 / 2; // 5

double x5 = 10;
double y5 = x5 / 3; // 3.333333

// ! When dividing, keep in mind that if both operands represent integers, then the result will also be rounded to an integer

double x6 = 10 / 4; /* Result will be = 2 
                     * Even the result of the operation is placed in a variable of the double type, 
                     * which allows you to save the fractional part, but the operation itself involves two literals, 
                     * which by default are considered as an integers, and the result will also be integer */

// To get out of this situation, it is necessary to define the literals or variables involved in the operation exactly as double or float types:

double x7 = 10.0 / 4.0; // Result will be = 2.5


// (%) Modulo - the operation of obtaining the remainder of an integer division of two numbers:

double x8 = 10.0;
double x9 = 18.0;
double y6 = x8 % 4.0;    // Result will be = 2
double y7 = x8 % 7.0;   // Result will be = 3;
double y8 = x9 % 7.0;  // Result will be = 4;
Console.WriteLine($"The results are: {y6}, {y7}, {y8}");


// UNARY - operations involving one operand

// (++) Increment operation

// Prefix: ++x - first the value of x is incremented by 1, and then its value is returned as the result of the operation

int x10 = 15;
int y9 = ++x10;                      // y9 = 16; x10 = 16;
Console.WriteLine($"{x10} - {y9}"); // 16 - 16 = 0

double x12 = 325.5;
double y11 = ++x12;                   // y11 = 326.5; x12 = 326.5;
Console.WriteLine($"{x12} - {y11}"); // 326.5 - 326.5 = 0;

// Postfix increment: x++ - first, the value of x is returned as the result of the operation, and then 1 is added to it

int x11 = 15;
int y10 = x11++;                      // y10 = 15; x11 = 16;
Console.WriteLine($"{x11} - {y10}"); // 16 - 15 = 1;

double x13 = 325.5;
double y12 = x13++;                   // y12 = 325.5; x13 = 326.5;
Console.WriteLine($"{x13} - {y12}"); // 326.5 - 325.5 = 1

// (--) Decrement - decrease a value by one. There is also a prefix decrement form (--x) and a postfix form (x--)

int x14 = 15;
int y13 = --x14;                      // y13 = 14; x14 = 14;    
Console.WriteLine($"{x14} - {y13}"); // 14 - 14 = 0;

int x15 = 15;
int y14 = x15--;                      // y14 = 15; x15 = 14;
Console.WriteLine($"{x15} - {y14}"); // 14 - 15 = -1;


/* The order in which operations are performed. Priority of operations from highest to lowest:
 * 1. Increment, decrement
 * 2. Multiplication, division, remainder
 * 3. Addition, subtraction

! Brackets are used to change the order of the operations */

int a = 3;
int b2 = 5;
int c5 = 40;
int d = c5---b2 * a; // a = 3; b = 5; c = 39; d = 25; 40 - 5 * 3 = 25;
Console.WriteLine($"a = {a}; b = {b2}; c = {c5}; d = {d}");

int a1 = 3;
int b1 = 5;
int c4 = 40;
int d3 = (c4-(--b1)) * a1; // a = 3; b = 4; c = 40; d = 108; (40 - (5-1)) * 3 = 108;
Console.WriteLine($"a = {a1}; b = {b1}; c = {c4}; d = {d3}");

// Associativity of operators

//Left associative operators - executes from left to right
// ! All arithmetic operators are left-associative, meaning they execute from left to right.

int x16 = 10 / 5 * 2; // (10/5) * 2 = 2 * 2 = 4

//Right associative operators - executes from right to left


/*
 * Bitwise Operations -  numbers are considered in binary representation.
 * For example: 2 in binary representation is 10 and has two digits.
 * The number 7 is 111 and has three digits 
 */

// Boolean operations 

/* (&) boolean multiplication - Multiplication is performed bit by bit. 
 * If both operands have bit values equal to 1, then the operation returns 1. 
 * Otherwise the number 0 is returned. */

// https://www.exploringbinary.com/decimal-binary-conversion-table/ - Decimal/Binary table

int x17 = 39;   // 100111
int y15 = 5;   // 000101
Console.WriteLine(x17 & y15); // 000101 (binary) = 5 (decimal)

int x18 = 4;   // 100
int y16 = 5;  // 101
Console.WriteLine(x17 & y15); // 100 (binary) = 4 (decimal)

/* (|) - logical addition - similar to logical multiplication.
 * The operation is also performed on binary digits. 
 * But now a 1 is returned if at least one number = 1 */

int x19 = 39;   // 100111
int y17 = 5;   // 000101
Console.WriteLine(x19 | y17); // 100111 (binary) = 39 (decimal)

int x20 = 2;   // 010
int y18 = 5;  // 101
Console.WriteLine(x20 | y18); // 111 (binary) = 7 (decimal)

/* (^) - logical XOR - excusive logical OR (исключающее ИЛИ)
 * Here again, bitwise operations are performed. 
 * If we have different values, then 1 is returned. 
 * Otherwise 0 is returned. 
 * 
! This operation is also called XOR, it is often used for simple encryption */

int x21 = 88;   // 1011000
int key = 105; // 1101001
int encrypt = x21 ^ key; // 1011000 ^ 1101001 = 0110001 (binary) = 49 (decimal)
Console.WriteLine($"Encrypted number is {encrypt}"); // 49
int decrypt = encrypt ^ key; // 0110001 ^ 1101001 = 1011000 (binary) = 88 (decimal)
Console.WriteLine($"Decrypted number is {decrypt}"); // 88

/* (~) - logical negation (отрицание) or inversion.
 * Another bitwise operation. Inverts all bits to opposite. 
 * If the value of a bit is 1, then it becomes 0, and vice versa. */

int x22 = 8;               
Console.WriteLine(~x22); // 00001000 -> 11110111 = -9 

int x23 = 9;
Console.WriteLine(~x23); // 00001001 -> 11110110 = -10

int x24 = 215;
Console.WriteLine(~x24); // 11010111 -> 00101000 = -216

// In order get a negative form from a positive number, you need to invert it and add 1:

int x25 = 5;      // 00000101
int y19 = ~x25;  // 11111010
y19 += 1;       // 11111010 + 1 = 11111011 = -5, So 5 has been changed to -5;
Console.WriteLine(~y19);

int x26 = 12;      // 00001100
int y20 = ~x25;  // 11110011
y19 += 1;       // 11110011 + 1 = 11110100, So 12 has been changed to -12;
Console.WriteLine(~y20);


// Shift operations - Shift can be left or right

/* x<<y - shifts the number X to the left by Y digits. 
 * For example, 4<<1 shifts the number 4 (which is 100 in binary) one digit to the left, resulting in 1000 or 8 in decimal */

/* x>>y - shifts the number X to the right by Y digits. 
 * For example, 16>>1 shifts the number 16 (which is 10000 in binary) one digit to the right, resulting in 1000 or 8 in decimal */

int x27 = 25;                                      // 00011001
int y21 = 2; 
int c3 = x27 << y21;                             // 01100100 (moved two simbols to the left)
Console.WriteLine($"Secret numer is {c3}");     // 100 (decimal)

int d4 = x27 >> y21;                          // 00000110 (moved two simbols to the right)
Console.WriteLine($"Secret number is {d4}"); // 6 (decimal)


/*
 * Assignment operations
 */


// (=) - the basic assignment operator, which assigns the value of the right operand to the left operand.

int number = 21; // The variable "number" represents the left operand, which is assigned the value of the right operand, which is the number 21

int a2, b3, c7, d6;
a2 = b3 = c7 = d6 = 100; // multiple assignment to several variables at once

// ! assignment operations have low precedence. At first, the value of the right operand will be calculated, and only then this value will be assigned to the left operand

int a3, b4, c8, d7;
a3 = b4 = c8 = d7 = 34*2/4; // a3 = b4 = c8 = d7 = 17

/* Other operations:
 * 
 * 
(+=) - assignment after addition. Assigns to the left operand the sum of the left and right operands: the expression A += B is equivalent to the expression A = A + B

(-=) - assignment after subtraction. Assigns to the left operand the difference of the left and right operands: A -= B is equivalent to A = A - B

(*=) - assignment after multiplication. Assigns to the left operand the product of the left and right operands: A *= B is equivalent to A = A * B

(/=) - assignment after division. Assigns the quotient of the left and right operands to the left operand: A /= B is equivalent to A = A / B

(%=) - assignment after modulo division. Assigns to the left operand the remainder of the integer division of the left operand by the right: A %= B is equivalent to A = A % B

(&=) - assignment after bitwise conjunction. Assigns to the left operand the result of the bitwise conjunction of its bit representation with the bit representation of the right operand: A &= B is equivalent to A = A & B

(|=) - assignment after bitwise disjunction. Assigns the left operand the result of the bitwise disjunction of its bit representation with the bit representation of the right operand: A |= B is equivalent to A = A | B

(^=) - Assignment after XOR operation. Assigns the left operand the result of XORing its bit representation with the bit representation of the right operand: A ^= B is equivalent to A = A ^ B

(<<=) - Assignment after shifting bits to the left. Assigns to the left operand the result of shifting its bit representation to the left by a specified number of bits equal to the value of the right operand: A <<= B is equivalent to A = A << B

(>>=) - assignment after bit shift to the right. Assigns to the left operand the result of shifting its bit representation to the right by a specified number of bits equal to the value of the right operand: A >>= B is equivalent to A = A >> B

*/

int a4 = 10;
a4 += 10;           // 20
a4 -= 5;           // 5
a4 *= 4;          // 40
a4 /= 5;         // 2
a4 %= 4;        // 2
a4 &= 5;       // 00001010 &= 00000101 = 00000000 = 0
a4 |= 5;      // 00001010 |= 00000101 = 00001111 = 15
a4 |= 2;     // 00001010 |= 00000010 = 00001010 = 10
a4 ^= 2;    // 00001010 ^= 00000010 = 00001000 = 8
a4 <<= 2;  // 00001010 <<= 00101000 = 40 (decimal)
a4 >>= 2; // 00001010 >>= 00000010 = 2 (decimal)

// Assignment operations are right-associative, that is, they are executed from right to left

int a5 = 8;
int b5 = 6;
int c9 = a5 += b5 -= 5; // (b5 - 5) + 8 = 1 + 8 = 9
Console.WriteLine(c9); // 9


/*
 * Basic Data Type Conversions
 */

byte b6 = 70;
int i6 = 4 + b6;
Console.WriteLine(i3);

byte b7 = 70;
byte b8 = 4 + b7; /* Error while compilation; We have to choose the value range for specific variable. 
                   * But in our case, the number 74 is quite within the range of values of the byte type. 
                   * The fact is that the operation of addition (and subtraction) returns a value of type int. 
                   * Therefore, the result of the operation 4 + b7 will be an object that has a memory length of 4 bytes. 
                   * Then we try to assign this object to the variable b8, which has the byte type and occupies 1 byte in memory. */

// Type conversion operation - we should use this to resolve the issue.
// (data type_to_convert) value to convert;

byte b9 = 70;
byte b10 = (byte)(4 + b9); // Solution

// Narrowing and Widening transformations

byte b11 = 4; // 0000100
ushort us3 = b11; // 00000000000000100 Widening transformations from byte to ushort. From byte (1 byte (8 bits)) to ushort (takes 2 bytes (16 bits)); 

ushort us4 = 4; // 00000000000000100
byte b12 = (byte)(us4); // 0000100 Narrowing transformations from ushort to byte. From ushort (takes 2 bytes (16 bits)) to byte (1 byte (8 bits));

// Explicit and implicit conversions (Явные и неявные преобразования)

/* Implicit Conversions
 * With widening conversions, the compiler performed all the data conversions for us, that is, the conversions were implicit conversions. Such transformations do not cause any difficulties.*/

// Zero extension - If a conversion is made from an unsigned type of lesser bit depth to an unsigned type of greater bit width, then extra bits are added that have values of 0. 
// Extension with zeros (0) if the number is positive, and ones (1) if the number is negative

sbyte sb2 = 4;
short s3 = sb2; // 0000000000000100. Zero's added to the front for positive number

sbyte sb3 = 4;
short s4 = sb3; // 111111111111100. Ones's added to the front for negative number

/* The compiler performs widening conversions from a type with a smaller bit width to a type with a larger bit width automatically.
 * All safe automatic conversions can be described by the following table:
 * 
 * byte --> short, ushort, int, uint, long, ulong, float, double, decimal;
  sbyte --> short, int, long, float, double, decimal;
  short --> int, long, float, double, decimal;
 ushort --> int, uint, long, ulong, float, double, decimal;
    int --> long, float, double, decimal;
   uint --> long, ulong, float, double, decimal;
   long --> float, double, decimal;
  ulong --> float, double, decimal;
  float --> double;
   char --> ushort, int, uint, long, ulong, float, double, decimal;

// Otherwise, explicit type conversions should be used

/* Explicit Conversions
 * With explicit conversions, we ourselves must apply the conversion operation (operation ()). 
 * Before the value, the type to which the given value should be placed in indicated brackets */

int i7 = 4;
int i8 = 5;
byte b13 = (byte)(i7 + i8); // (byte) added to convert

/* ! It should also be noted that despite the fact that both double and decimal can store fractional data, 
 * And decimal has a larger bit depth than double, 
 * You still need to explicitly conversions the double value to the decimal type: */

double d5 = 4.4;
decimal dec5 = (decimal)d5;

// Data loss and the "checked" keyword

int i9 = 600;
int i10 = 33;
byte b14 = (byte)(i9 + i10);
Console.WriteLine(b14); // The result will be 121. Why??? 

/* The result will be 121, so 633 is out of range for the byte type, and the high bits will be truncated.
 * In this case, we can either take such numbers i9 and i10, which in total will give a number no more than 255, or we can choose another data type instead of byte, for example, int. */

/* However, the situations may be different. We may not know exactly what values i11 and i12 will have. And to avoid such situations, c# has the "checked" keyword.
 * When using the checked keyword, the application throws an overflow exception. In this case we use "try...catch" construct to process it. 
 * We include actions in the "try" block in which an error can potentially occur, and we handle the error in the "catch" block.*/

try
{
    int i11 = 600;
    int i12 = 33;
    byte b15 = checked((byte)(i11 + i12)); // using a "checked" keyword
    Console.WriteLine(b15);
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message); // An arithmetic operation resulted in an overflow
}


/*
 * Conditional expressions - Such operations return a boolean value, that is, a value of type bool: true if the expression is true, and false if the expression is false.
 */

// Comparison operations

// (==) Compares two operands for equality. If they are equal, then the operation returns true, if not equal, then false is returned.

int a6 = 10;
int b15 = 5;
bool c15 = a6 == b15; // false
bool c16 = a6 == 10; // true

// (!=) Compares two operands and returns true if the operands are not equal and false if they are equal.

int a7 = 10;
int b16 = 5;
bool c17 = a7 != b16; // true
bool c18 = a7 != 10; // false


// (<) Compares two operands and returns true if the operands are not equal and false if they are equal.

int a8 = 10;
int b17 = 5;
bool c19 = a8 < b17; // false
bool c20 = a8 < 15; // true

// (>) Less than operation. Returns true if the first operand is less than the second, and false if the first operand is greater than the second.

int a9 = 10;
int b18 = 5;
bool c21 = a9 > b18; // true
bool c22 = a9 > 15; // false

// (<=) Less than or equal to operation. Compares two operands and returns true if the first operand is less than or equal to the second. Otherwise returns false.

int a10 = 10;
int b19 = 5;
bool c23 = a10 <= b19; // false
bool c24 = a10 <= 10; // true

// (>=) Greater than or equal to operation. Compares two operands and returns true if the first operand is greater than the second, otherwise returns false.

int a11 = 10;
int b20 = 10;
bool c25 = a11 >= b20; // true
bool c26 = a11 >= 100; // false

// ! The operators <, > <=, >= have higher priority than == and !=


// Boolean operations - return a bool value. Typically applied to relations and combines multiple comparison operations.

// (|) The operation of logical addition or logical OR. Returns true if at least one of the operands returns true.

bool c27 = (10 > 5) | (100 < 5); // 10 > 5 true, 100 < 5 false. Returns True;
bool c28 = (10 > 5) | (1 < 5); // 10 > 5 true, 1 < 5 True. Returns True;
bool c29 = (10 < 5) | (100 < 5); // 10 < 5 false, 100 < 5 false. Returns False;

// (^) Exclusive OR operation. Returns true if either the first or second operand (but not both) are true, otherwise returns false

bool c30 = (10 > 5) | (1 < 5); // 10 > 5 true, 1 < 5 True. Returns False; Note this.
bool c31 = (10 > 5) | (100 < 5); // 10 > 5 True, 100 < 5 false. Returns True;

// (&) Boolean multiplication or logical AND. Returns true if both operands are both true at the same time.

bool c32 = (10 > 5) | (1 < 5); // 10 > 5 true, 1 < 5 True. Returns True;
bool c33 = (10 > 5) | (100 < 5); // 10 > 5 True, 100 < 5 false. Returns False;

// (!) - Operation of logical negation. Performed on a SINGLE operand and returns true if the operand is false. If the operand is true, then the operation returns false and vice versa

bool c34 = true;
bool c35 = !c34; // returns False;

bool c36 = false;
bool c37 = !c36; // returns True;

/* In the expression z=x|y; both x and y values ​​will be calculated.
 * 
In the expression z=x||y; first, the equivalent value of x will be calculated, and if it is equal to the calculation of the value of x, then the value of y no longer matters, since in any case we already have z equal to true. 
The value of y will only be evaluated if x is false;

In the expression z=x&y; both x and y values ​​will be calculated.
In the expression z=x&&y; first, the calculated x value will be calculated, and if it is equal to the calculated x value, then the y value no longer makes sense, since in any case, z will already be equal to false. 
The value of y will only be evaluated if x is true;

Therefore, the operation || and && is more convenient in calculations, as it allows you to reduce the time to calculate the value of the expression, and thus the greatest performance. 
A operation | and & larger plan for performing bitwise operations on numbers. */

// (||) The operation of logical addition or logical OR. Returns true if at least one of the operands returns true.

bool c38 = (10 > 5) | (100 < 5); // 10 > 5 true, 100 < 5 false. Returns True; // no reason to check second condition. In any way result will be True;
bool c39 = (10 > 5) | (1 < 5); // 10 > 5 true, 1 < 5 True. Returns True; // no reason to check second condition. In any way result will be True;
bool c40 = (10 < 5) | (100 < 5); // 10 < 5 false, 100 < 5 false. Returns False;

// (&&) Boolean multiplication or logical AND. Returns true if both operands are both true at the same time.

bool c41 = (10 > 5) | (1 < 5); // 10 > 5 true, 1 < 5 True. Returns True;
bool c42 = (10 > 5) | (100 < 5); // 10 > 5 True, 100 < 5 false. Returns False;
bool c43 = (10 < 5) | (100 < 5); // 10 < 5 False, 100 < 5 false. Returns False; // no reason to check second condition. In any way result will be False;