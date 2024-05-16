Console.WriteLine("******* Array*******");
int[] marks = { 50, 35,70, 90};
string[] names = new string[3];

for (int i = 0; i < marks.Length; i++)
    Console.WriteLine(marks[i]);

//for (int i = 0; i < names.Length; i++)
//    names[i] = Console.ReadLine();

//for (int i = 0; i < names.Length; i++)
//    Console.WriteLine(names[i]);

Console.WriteLine("******* Lists *******");

//List<int> numbers = new List<int>();
List<object> numbers = new();
numbers.Add(30);
Console.WriteLine(numbers.Count);
numbers.Add(40.6);
numbers.Add('A');
numbers.Add("Name");

foreach (object number in numbers)
    Console.WriteLine(number);

Console.WriteLine(numbers.Count);


