
string? firstName = "Queen";
string lastName = string.Empty;
int age;
char gender  = char.MinValue;
float salary;

Console.WriteLine("What is your first name?");
firstName = Console.ReadLine();

Console.WriteLine("What is your last name?");
lastName = Console.ReadLine();

Console.WriteLine("What is your gender?");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("What is your salary?");
salary = float.Parse(Console.ReadLine());


Console.WriteLine("How old are you?");
string userInput = Console.ReadLine();

age =  int.Parse(userInput);

Console.WriteLine($"Your name is: {firstName} {lastName}");
Console.WriteLine($"You are {age} years old");
Console.WriteLine($"You are: {gender}");