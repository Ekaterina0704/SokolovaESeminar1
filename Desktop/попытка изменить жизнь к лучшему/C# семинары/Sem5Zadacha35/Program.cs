// задать массив определить количество чисел лежащих в диапазоне

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

int FindNumber (int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>=10 && arr[i]<100) count++;
    }
    return count;
}

int [] array = Createarray(123,0,150);
PrintArray(array);
int findnumber = FindNumber(array);
Console.WriteLine($"Количество чисел в массиве, лежащих в заданном диапазоне = {findnumber}");