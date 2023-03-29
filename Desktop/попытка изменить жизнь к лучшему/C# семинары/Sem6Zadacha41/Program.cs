// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Напишите количество чисел которое вы введете:");
int count = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите значение: ");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
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
    Console.Write("]");
}

int Colichestvo(int [] arr)
{
    int result =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) result +=1;
    }
    return result;
}

int [] createarray= CreateArray(count);
PrintArray(createarray);
int colichestvo = Colichestvo(createarray);
Console.WriteLine($"Количество введенных положительных чисел = {colichestvo}");