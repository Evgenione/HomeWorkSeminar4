int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for(int i=1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    // int result = Math.Pow(numberA, NumberB);
    return result;
}

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ:  " + exponentiation);