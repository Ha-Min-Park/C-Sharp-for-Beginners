// See https://aka.ms/new-console-template for more information
Console.WriteLine("I'm Hamin!");

string firstFriends = "Nicole";
string secondFriends = "Ray";

// Composite formatting:
Console.WriteLine($"hello {firstFriends} and {secondFriends}");
// String interpolation:
Console.WriteLine("Hello " + firstFriends + " and " + secondFriends);

string greeting = $"hello {firstFriends} and {secondFriends}";
Console.WriteLine(greeting);
greeting = greeting.Replace("Ray", "Donna");
Console.WriteLine(greeting);


