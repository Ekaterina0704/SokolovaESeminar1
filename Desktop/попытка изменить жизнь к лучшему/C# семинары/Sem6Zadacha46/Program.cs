// Выведите первые n чисел числа фибоначчи 

Console.WriteLine("Введите желаемое количество цифр из числа фибоначчи:");
int quantity = Convert.ToInt32(Console.ReadLine());

int[] Number(int size)
{
    int[] arr = new int[size];
    arr[0]=0;
    arr[1]=1;
    {
        for (int i = 2; i < size; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
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

int [] number = Number(quantity);
PrintArray(number);
