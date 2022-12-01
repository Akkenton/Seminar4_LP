// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SummA(int count)
{
    int result = 0;
    for (int i = 1; i <= count; i++)
    {
        result = result + i;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int valueA = int.Parse(Console.ReadLine());

int result = SummA(valueA);
Console.WriteLine($"Итоговое значение: {result}");