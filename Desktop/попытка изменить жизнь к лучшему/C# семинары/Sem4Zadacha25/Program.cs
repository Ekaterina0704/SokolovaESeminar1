Console.WriteLine("Введите 1е число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень:");
int number2 = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    int multiplication = 1;
    for (int i = 1; i <= num2; i++)
    {
        multiplication = multiplication * num1;
    }
    return multiplication;
}

bool Naturalnumber(int num2)
{
    return num2 > 0;
}

Console.WriteLine(Naturalnumber(number2) ? Degree(number1, number2) : "Введите положительное число в качестве степени");
