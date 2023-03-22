// Задать массив и посчитать сумму положительных и отрицательных элементов

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();


    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int GetSummnegatineElem(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) summ += arr[i];
    }
    return summ;
}


int GetSummpositiveElem(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) summ += arr[i];
    }
    return summ;
}

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int summnegatineElem= GetSummnegatineElem(array);
int summpositiveElem=GetSummpositiveElem(array);
Console.WriteLine($"Сумма положительных элементов = {summpositiveElem}");
Console.WriteLine($"Сумма отрицательных элементов = {summnegatineElem}");
