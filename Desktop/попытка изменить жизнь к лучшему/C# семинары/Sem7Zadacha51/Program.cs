// задать двумерный массив найти сумму элементов лежащих на главной диагонали

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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

// int Summ(int[,] matrix)
// {
//     int summ = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) summ += matrix[i, j];
//         }

//     }
//     return summ;
// }

int Summ(int[,] matrix)
{
    int summ = 0;
    for (int i = 0; i < matrix.GetLength(0)&& i<matrix.GetLength(1); i++)
    {
        summ+=matrix[i,i];
    }
    return summ;
}    

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
int summ= Summ(array2d);
Console.WriteLine($"Сумма элементов, лежащих на главной диагонали = {summ}");