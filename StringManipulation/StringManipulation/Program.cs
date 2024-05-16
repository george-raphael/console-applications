//Initialise with a regular string literal
string name = "George Raphael";

//Declare without initialising - (Has a possible null exception)
string message;

//Initialise to null - (Has a possible null exception)
string message2 = null;

//Using empty string string.Empty
string message3 = string.Empty;

//Escape sequences \ - \r -\n
//Console.WriteLine("George Said, \"I will come to the\r class tommorrow\"");
int i = 1;
/*
while(i < 10)
{
    Console.Write($"\r{i}");
    Thread.Sleep(1000);
    i++;
}*/

//Verbatim string - used to output the string as is - (@)
Console.WriteLine(@"George Said, \nI will come to the class tommorrow\n");

//Define a const string using const keyword
//Define a const string using const keyword
const string name2 = "Irfan";

// name2 = "Fransisca"; this is not allowed!!!

//Raw string using “””” String””””  . 
Console.WriteLine(" Normal string" +
    "Another" +
    "String");


Console.WriteLine(""" 
    
    Raw string      Text            Text2
    Another
    String
    
    """);


int age = 50;
age = 60;

//Review concatenation
string s1 = "String One";
string s2 = "String Two";

s1 += s2;

Console.WriteLine(s1);

//String Format
string msg = "123 Iyunga - Mbeya";
Console.WriteLine("My name is {0} I come from {1}", name, msg);

//String Methods

//Find length s1.Length 
Console.WriteLine(msg.Length);

//Substract a string from another string
string s3 = "Hello, My name is Kevin";
string sub = s3.Substring(6, 12);
Console.WriteLine(sub);

//Split string
string s4 = "George Cosmas-Mathias -Amani";
var splittedString = s4.Split('-');

for(i = 0; i < splittedString.Length; i++)
{
    Console.WriteLine(splittedString[i]);
}

//Replace
Console.WriteLine(s4.Replace("as", "AS"));

//Convert to string
int number = 40;
float numberf = 40f;
bool isAdult = true;

Console.WriteLine(number.ToString());
Console.WriteLine(numberf.ToString());
Console.WriteLine(isAdult.ToString());

//Changing format while converting
int salary = 50000;

Console.WriteLine(salary.ToString("C"));

