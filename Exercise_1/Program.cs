int a = GetNumber("Enter your first number ");
int b = GetNumber("Enter your second number ");
WhichIsBigger(a, b);


void WhichIsBigger(int a, int b)
{
    int max = 0;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    Console.WriteLine($"a = {a}; b = {b} ->  max = {max}");
}


int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}