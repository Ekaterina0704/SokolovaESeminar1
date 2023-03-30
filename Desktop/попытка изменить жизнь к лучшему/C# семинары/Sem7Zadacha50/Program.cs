// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];//0 и 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4 }");
        }
        Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
Console.WriteLine("Введите строку для поиска наличия элемента в массиве:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец для поиска наличия элемента в массиве:");
int colum = Convert.ToInt32(Console.ReadLine());
int result = Result(array2d, row, colum);
Console.WriteLine( Number(array2d, row, colum) ? $"число в массиве с такими индексами = {result}" : "Нет, такого элемента в массиве нет");

bool Number(int[,] matrix, int a, int b)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==a && j==b) return true;
        }
    }
    return false;
}

int Result(int[,] matrix, int a, int b)
{
    int result=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result = matrix[a,b];
        }
    }
    return result;
}