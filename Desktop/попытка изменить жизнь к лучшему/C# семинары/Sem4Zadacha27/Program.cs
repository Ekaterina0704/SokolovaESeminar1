// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Summaglobal(int num)
{
    int summ = 0;
    do
    {
        int remainder = num % 10;
        summ = summ + remainder;
        num = num / 10;
    }
    while (num != 0);
    return summ;
}

int count = Summaglobal(number);
Console.WriteLine($"В числе {number} cумма цифр = {count}");
