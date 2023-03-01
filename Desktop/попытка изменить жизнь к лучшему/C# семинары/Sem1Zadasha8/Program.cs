Console.Write("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int a = 2;
if (number>0)
{
    while (a<=number)
    {
        Console.Write(a);
        a=a+2;
    }
}
else
{
    Console.Write("Введено ненатуральное число");
}