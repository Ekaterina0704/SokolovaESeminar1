// задать массив определить есть ли заданное число в массиве

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

bool Availability (int numb, int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i]== numb) return true;
    }
    return false;
}

int [] array = Createarray(7,-10,10);
PrintArray(array);
Console.WriteLine("Введите число для поиска в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Availability(number, array) ? "Да, данное число есть в массиве" : "Нет, данного числа нет в массиве");