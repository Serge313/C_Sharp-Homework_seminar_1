int yourNumber = GetNumber("Enter your number ");
EvenOrOdd(yourNumber);


void EvenOrOdd(int a)
{
    if (a % 2 == 0 & a / 2 != 0)
    {
        Console.WriteLine($"{a} -> \"yes\"");
    }
    if (a % 2 != 0)
    {
        Console.WriteLine($"{a} -> \"no\"");
    }
    if (a == 0)
    {
        Console.WriteLine("Choose a number not equal to 0");
    }
}


int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}