// пеобразование десятичного числа в двоичное

Console.Write("Введите число в десятичной системе счисления:");
int number = Convert.ToInt32(Console.ReadLine());

int Translate (int num)
{
    int result =0;
    int discharge = 1;
    while (num!=0)
    {
        result=result+(num%2)*discharge;
        num/=2;
        discharge*=10;
    }
    return result;
}

Console.WriteLine($"Число {number} в десятичной системе счисления = {Translate(number)}");
