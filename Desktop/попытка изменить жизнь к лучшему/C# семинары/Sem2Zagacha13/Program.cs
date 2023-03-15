Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<100) 
Console.WriteLine("третьей цифры у числа нет");
else 
{
    while (number>999)
    {
        number=number/10;
    }
int thirddigit = number%10;
Console.WriteLine($"Третья цифра числа ->{thirddigit}");
}