
// int summ= Summ(A);
// Console.Write(summ);
Console.Write($"Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int mult= Mult(A);
Console.Write(mult);

int Mult(int num)
{
    int mult=1;
    for (int i=1; i <= num; i++)
    {
        mult=mult*i;
    }
    return mult;
}