// создать копию массива с помощью элементарного копирования

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

int [] Copyarray(int []arr)
{
    int [] newarray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newarray[i]=arr[i];
    }
    return newarray;
}

int [] createarray= Createarray(5,0,9);
PrintArray(createarray);

int [] copyarray= Copyarray(createarray);
copyarray[0]=45;
PrintArray(copyarray);
