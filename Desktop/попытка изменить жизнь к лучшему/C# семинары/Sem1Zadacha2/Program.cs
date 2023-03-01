Console.WriteLine("Введите 1е число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1==number2) Console.Write("Числа равны");
else if (number1>number2)
{
    Console.WriteLine($"{number1} - наибольшее число, {number2} - наименьшее число");
}
else
{
    Console.WriteLine($"{number2} - наибольшее число, {number1} - наименьшее число");  
}