// задать двумерный массив
// поменять первую и последнюю строки массива местами

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
            Console.Write($"{matrix[i, j], 4  }");
        }
        Console.WriteLine();
    }
}

void Reverse (int[,] arr)
{
    int lastRowIndex= arr.GetLength(0);
    int firstRowIndex=0;
     for (int j = 0; j < arr.GetLength(1); j++)
        { 
           int temp=arr[firstRowIndex,j];
           arr[firstRowIndex,j]=arr[lastRowIndex-1,j];
           arr[lastRowIndex-1,j]=temp;
        }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Reverse(array2d);
Console.WriteLine();
PrintMatrix(array2d);
