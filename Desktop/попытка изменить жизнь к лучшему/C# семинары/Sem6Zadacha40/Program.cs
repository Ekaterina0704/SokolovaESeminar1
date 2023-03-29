// на вход 3 числа и проверить существует ли такой треугольник в реальности

Console.Write("Введите 1е число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2е число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3е число:");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Еriangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1) return true;
    else return false;
}

string output = Еriangle(number1,number2,number3) ? "Да,такой треугольник существует" : "Нет, такого треугольника нет";
Console.WriteLine (output);