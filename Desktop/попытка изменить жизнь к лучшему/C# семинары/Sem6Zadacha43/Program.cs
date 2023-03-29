// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// задача не доделана тк у меня не вещественные а целые числа

Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

void PossibleCoincidenceValues(double k1, double k2, double b1, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
    }
}

int[] Number(int k1, int k2, int b1, int b2)
{
    int[] arr = new int[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = arr[0] * k1 + b1;
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

PossibleCoincidenceValues(k1, k2, b1, b2);
int [] number = Number(k1, k2, b1, b2);
PrintArray(number);
