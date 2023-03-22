// создать массив и заменить элементы на противоположные

int[] CreateArrayRndInt(int size, int min, int max)
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

void Replacement (int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i]* -1;
    }
}

int[] array = CreateArrayRndInt(7, -10, 10);
PrintArray(array);
Replacement(array);
PrintArray(array);
