// задать массив заполненный произвольными положительными трехзначными числами
// посчитать количество четных чисел в массиве

int [] Createarray (int size, int min, int max)
{
    int [] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i]=rnd.Next(min,max);
    }
    return arr;
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int СountingEvenNumbers (int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) count++;
    }
    return count;
}

int [] array = Createarray(7,100,1000);
PrintArray(array);
int countingEvenNumbers = СountingEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве= {countingEvenNumbers}");
