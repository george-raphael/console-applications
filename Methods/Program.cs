
Console.WriteLine("******Methods******");

//Anatomy - (syntax)

//void functions/methods
void GetInfo(string name)
{
    Console.WriteLine($"My name is {name}");
}

GetInfo("Hamisi");
//functions with return statements
string GetUserInfo(string name)
{
    return $"My name is {name}";
}

Console.WriteLine(GetUserInfo("Anna"));

//methods with optional arguments
string GetUserData(string name = "Bill")
{
    return $"My name is {name}";
}

Console.WriteLine(GetUserData());

//methods with nullable arguments
int GetMyUserData(string? name)
{
    //return $"My name is {name}";
    if (!String.IsNullOrEmpty(name))
    {
        return name.Length;
    }
    else
    {
        return 0;
    }
}

//methods with nullable arguments
string SetUserName(string? name)
{
    name ??= "Daudi";

    return name;
}
Console.WriteLine(SetUserName("Dotto"));