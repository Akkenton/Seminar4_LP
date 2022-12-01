

int NumberAdd()
{
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int ResultNumber(int number)
{
    int result = 1;
    for (var i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

int value = NumberAdd();
int result = ResultNumber(value);
Console.WriteLine($"Значение: {result}");