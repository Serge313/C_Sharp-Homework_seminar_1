int firstNumber = GetNumber("Enter your first number ");
int secondNumber = GetNumber("Enter your second number ");
int thirdNumber = GetNumber("Enter your third number ");
WhichIsBigger(firstNumber, secondNumber, thirdNumber);


void WhichIsBigger(int a, int b, int c)
{
    int max = 0;
    if (a > b & a > c)
    {
        max = a;
        Console.WriteLine($"a = {firstNumber}; b = {secondNumber}; c = {thirdNumber}; -> max = {max}");
    }
    if (b > a & b > c)
    {
        max = b;
        Console.WriteLine($"a = {firstNumber}; b = {secondNumber}; c = {thirdNumber}; -> max = {max}");
    }
    if (c > a & c > b)
    {
        max = c;
        Console.WriteLine($"a = {firstNumber}; b = {secondNumber}; c = {thirdNumber}; -> max = {max}");
    }
    if (a == b & b == c)
    {
        Console.WriteLine("a = b = c");
    }
}


int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}