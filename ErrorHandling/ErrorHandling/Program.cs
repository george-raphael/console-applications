
int num1, num2, result;
string errorMessage = "";

Console.WriteLine("********Divition Calculator******* \n");

try
{
    Console.WriteLine("Please enter first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    result = num1 / num2;
    Console.WriteLine($"The result of dividing {num1} and {num2} is {result} ");

}
catch (FormatException error)
{
    errorMessage = "Tafadhali weka namba tu: Usiwe mbuzi!";
}
catch (DivideByZeroException error)
{
    errorMessage = "Hauwezi kugawanya kwa sifuri";
}
catch (Exception error)
{
    errorMessage = "Something went wrong";
}
finally
{
    Console.WriteLine(errorMessage);
    Console.WriteLine("Program finished!");
}



