Console.Write($"Введите пятизначное число: ");
int number= Convert.ToInt32(Console.ReadLine());

bool Fivedigitnumber (int num)
{
    return num<=99999 && num>=10000;
}

bool Palindrome(int num)
{
        int a=num/10000;
        int b=num%10;
        int c=num/1000%10;
        int d=num/10%10;
        return a==b && c==d;
}

if (Fivedigitnumber(number))
{
    Palindrome(number);
    Console.WriteLine(Palindrome(number)?"Да, число является палиндромом": "Нет, число не является палиндромом");
}
else
Console.Write("Введите пятизначное число");