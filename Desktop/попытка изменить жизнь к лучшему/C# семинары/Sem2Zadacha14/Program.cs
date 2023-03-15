Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7==0 && number % 23==0)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет"); 

Console.WriteLine(Multiply(number)? "Да": "Нет");

bool Multiply(int num)
{
    return number % 7==0 && number % 23==0;
}

