﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.Write($"[");
    int count = arr.Length;
    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($" {arr[i]},");
    }
    Console.Write($" {arr[count - 1]}");
    Console.Write("]");
}
FillArray(array);
PrintArray(array);