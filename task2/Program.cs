// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



// ---------------------------------- START  ---------------------------------------------------------------

int DataEntry() // метод ввода числа
{
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}


int CountOfNumber(int number)  // метод подсчета количества чисел
{
    int count = 0;
    if (number < 0) number = -number;
    for (int i = 0; number > 0; i++)
    {
        number = number / 10;
        count++;
    }
    return count;
}

// ---------------------------------------  Рабочая область  ------------------------------------------------

int number = DataEntry();
int count = CountOfNumber(number);

Console.WriteLine($"Количество цифр: {count}");

// ---------------------------------------  END  ----------------------------------------------------------