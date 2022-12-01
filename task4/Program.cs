
int LengthOfArray()
{
    Console.Clear();
    Console.WriteLine("Введите длинну масива: ");
    int length = int.Parse(Console.ReadLine());
    return length;
}

int[] FillArrayRandom(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] arr, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i]);
    }
}

int size = LengthOfArray();
int[] arr = FillArrayRandom(size);
PrintArray(arr, size);