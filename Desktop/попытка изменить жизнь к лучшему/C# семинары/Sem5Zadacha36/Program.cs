//задать массив случайными числами
//найти сумму элементов на нечетных позициях

int[] Createarray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int Sum(int[] arr)
{
    int summa = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) summa = summa + arr[i];
    }
    return summa;
}

int[] array = Createarray(5, -10, 10);
PrintArray(array);
int sum = Sum(array);
Console.WriteLine($"Сумма элементов, лежащих на нечетных позициях = = {sum}");
