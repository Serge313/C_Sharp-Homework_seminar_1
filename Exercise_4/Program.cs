int yourNumber = GetNumber("Enter your number ");
int size = yourNumber / 2;
int[] array = new int [size];
FillArray(array, yourNumber);
PrintArray(array);


void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length - 1)
        {
            Console.Write(array1[i] + ", ");
        }
        else
        {
            Console.Write(array1[i]);
        }
    }
}


void FillArray(int[] array1, int a)
{
    if (a % 2 == 0)
    {
        for (int i = array1.Length - 1; i >= 0; i--)
        {
            array1[i] = a;
            a = a - 2;
        }
    }
    else
    {
        a = a - 1;
        for (int i = array1.Length - 1; i >= 0; i--)
        {
            array1[i] = a;
            a = a - 2;
        }
    }
}


int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}