int a = GetNumber("Enter your first number ");
int b = GetNumber("Enter your second number ");
WhichIsBigger(a, b);


void WhichIsBigger(int a, int b)
{
    int max = 0;
    if (a > b)
    {
        max = a;
        Console.WriteLine($"a = {a}; b = {b} ->  max = {max}");
    }
    else if (b > a)
    {
        max = b;
        Console.WriteLine($"a = {a}; b = {b} ->  max = {max}");
    }
    else
    {
        Console.WriteLine("a = b");
    }
}


int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}