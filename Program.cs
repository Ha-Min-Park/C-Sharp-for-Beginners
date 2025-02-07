// See https://aka.ms/new-console-template for more information

// Numbers, Precision, Casting, Doubles, and More [Pt 8]
double a = 42.1; // natural type
float b = 38.2F;
double c = checked(a + b);
Console.WriteLine(c);

decimal d = 42.1M; // explicit type
decimal e = 38.2M;
decimal f = d + e;
Console.WriteLine($"The answer is {f}");

// Numbers, Integers, and Math [Pt 7]
/*
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int d = 2100000000;
int e = 2100000000;
int f = d + e;
long g = d + e;

long h = (long)d + (long)e; // explicit casting
Console.WriteLine($"f is {f}");
Console.WriteLine($"g is {g}");
Console.WriteLine($"h is {h}");

long i = checked(d + e); // overflow check
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
*/

/*
Console.WriteLine("I'm Hamin!");
*/

/*
// Searching Strings [Pt 6]
string greeting = $"hello {firstFriends} and {secondFriends}";
Console.WriteLine(greeting);

greeting = greeting.Replace("Ray", "Donna");
Console.WriteLine(greeting);

Console.WriteLine(greeting.Contains("Ray"));
Console.WriteLine(greeting.Contains("Donna"));

Console.WriteLine(greeting.ToUpper());

Console.WriteLine(greeting.Length);

Console.WriteLine(greeting.StartsWith("hello"));
Console.WriteLine(greeting.EndsWith("Ray"));
*/

/*
// The Basics of Strings! [Pt 5] | C# for Beginners
string thirdFriends = "     Donna     ";
thirdFriends = thirdFriends.Trim();
Console.WriteLine(thirdFriends);

string forthFriends = "     Jonathan     ";
Console.WriteLine(forthFriends.TrimStart());

string fifthFriends = "     Greg     ";
Console.WriteLine(fifthFriends.TrimEnd());

// Hello World, Introducing Strings! [Pt 4] | C# for Beginners
string firstFriends = "Nicole";
string secondFriends = "Ray";

// String interpolation:
Console.WriteLine($"hello {firstFriends} and {secondFriends}");
// Concatenate formatting: 
Console.WriteLine("Hello " + firstFriends + " and " + secondFriends);
*/



