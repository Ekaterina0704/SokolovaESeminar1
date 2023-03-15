Console.WriteLine("Введите 1е число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2е число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int multiplicity=Multiplicity(number1,number2);
Console.WriteLine(multiplicity==0?"Кратно":$"Некратно, остаток ->{multiplicity}");

int Multiplicity(int num1, int num2)
{
    return num1%num2;
}
