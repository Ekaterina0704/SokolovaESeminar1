Console.Write($"Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    int i=1;
    int result=1;
    while (i<=num)
    {
        result=i*i;
        Console.WriteLine($"{i} {result}");
        i++;
    }
}

Square(number);