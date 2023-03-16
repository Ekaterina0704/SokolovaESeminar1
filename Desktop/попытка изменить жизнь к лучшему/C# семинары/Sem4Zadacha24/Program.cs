//cумма чисел от 0 до заданного числа
Console.Write($"Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

// int Summ(int num)
// {
//     int summa=0;
//     int i = 0;
//     while (i<=num)
//     {
//         summa=summa+i;
//         i++;
//     }
//     return summa;
// }

// int summ= Summ(A);
// Console.Write(summ);

int summ= Summ(A);
Console.Write(summ);

int Summ(int num)
{
    int summa=0;
    for (int i=1; i <= num; i++)
    {
        summa=summa+i;
    }
    return summa;
}