﻿// задать массив вещественных чисел 
// найти разницу между максимальным и минимальным элементами

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min), 1) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double GetMaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double GetMinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double GetDiffMinAndMaxElements(double[] arr)
{
    return GetMaxElement(arr) - GetMinElement(arr);
}

double[] array = CreateArrayRndDouble(5, 0, 20);
Console.WriteLine("Массив:");
PrintArray(array);
double diff = Math.Round(GetDiffMinAndMaxElements(array), 1);
Console.WriteLine($"Разница между максимальным и минимальным элементами =: {diff}");