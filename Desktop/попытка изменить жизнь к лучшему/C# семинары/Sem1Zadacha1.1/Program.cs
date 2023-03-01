Console.Write("Введите 1е число:");
int number1= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число:");
int number2= Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2)
{  Console.Write("Да, 1е число явл квадратом второго");  
}
else       
{
    Console.Write("Нет, 1е число не явл квадратом второго");  
}