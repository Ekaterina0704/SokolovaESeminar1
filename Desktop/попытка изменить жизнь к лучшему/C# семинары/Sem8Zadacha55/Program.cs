// задать двумерный массив 
// заменить строки на столбцы

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
            Console.Write($"{matrix[i, j],4 }");
        }
        Console.WriteLine();
    }
}

int[,] Reverse (int[,] matrix)
{
    int[,] array = new int[matrix.GetLength(0), matrix.GetLength(1)];//0 и 1
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i,j]=matrix[j,i]; 
        }
    }
    return array;
}

// bool Verification(int[,] matrix)
// {
//     if (matrix.GetLength(0)=matrix.GetLength(1)) return true;
//     else return false;
// }

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[,]reverse = Reverse(array2d);
// Console.WriteLine (Verification(array2d) ? $"{reverse}" :"Нет, это невозможно");
PrintMatrix(reverse);