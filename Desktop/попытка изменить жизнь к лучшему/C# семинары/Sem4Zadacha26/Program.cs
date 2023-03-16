Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Count(int num)
{
    int digit=0;
    do
    {
        num/=10;
        digit++;
    }
    while (num!=0);
    return digit;
}

int count= Count(number);
Console.WriteLine($"В числе {number} содержится {count} цифр");