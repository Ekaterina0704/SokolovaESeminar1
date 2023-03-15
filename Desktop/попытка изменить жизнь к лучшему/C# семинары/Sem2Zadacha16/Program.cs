Console.WriteLine("Введите 1е число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2е число:");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1==number2*number2)
//      Console.WriteLine("Да, одно из чисел является квадратом второго");
// else if (number2==number1*number1)
//      Console.WriteLine("Да, одно из чисел является квадратом второго");
// else 
//      Console.WriteLine("Нет, ниодно из чисел не является квадратом второго");

Console.WriteLine(Square(number1, number2)?"ДА":"нет");

bool Square(int num1,int num2)
{
    return num1==num2*num2||num2==num1*num1;
}