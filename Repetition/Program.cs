Console.WriteLine("***** Put numbers to calculate sum *****");
/*
for(int i = 0; i < 10; i++)
    Console.WriteLine("Hello from George!");
*/
int input = 0;
int sum = 0;

/*Condition controlled while loop
while (input != -1)
{
    continue;
    input = Convert.ToInt32(Console.ReadLine());
    if(input != -1) sum += input;
}
Console.WriteLine($"Sum is : {sum}");
*/
//Continue example
for (int i = 0; i > 0; i++)
{
    if (i % 2 == 0) break;
        Console.WriteLine($"Hello from George! {i}");
}
