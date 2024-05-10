
string name = "Frank";
float age = 10.0f;

Console.WriteLine("What is your name?");
name = Console.ReadLine();

Console.WriteLine("How old are you?");
string userInput = Console.ReadLine();

age =  float.Parse(userInput);

Console.WriteLine("Your name is: " + name);
Console.WriteLine($"You are {age} years old");
