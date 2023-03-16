Console.Write($"Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int i=1;
    int result=0;
    while (i<=num)
    {
        result=i*i*i;
        Console.WriteLine($"{i} {result}");
        i++;
    }
}

Cube(number);
