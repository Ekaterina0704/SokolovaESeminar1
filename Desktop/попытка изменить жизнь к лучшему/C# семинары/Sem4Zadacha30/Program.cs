﻿// задать массив с рандомными числами

int[] array = new int[8];

void FillArray(int[]arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        arr[i]=new Random().Next(0,2);
    }
}

void PrintArray(int[]arr)
{
    int count = arr.Length;
    for (int i=0;i< count;i++)
    {
        Console.Write($"{arr[i] }");
    }
}
FillArray(array);
PrintArray(array);