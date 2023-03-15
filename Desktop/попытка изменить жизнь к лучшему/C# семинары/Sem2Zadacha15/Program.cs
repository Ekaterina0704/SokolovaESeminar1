Console.WriteLine("Введите день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number<0 && number>8)
Console.WriteLine("Введите корректный день недели");
else if (number>5)
Console.WriteLine("Выходной день");
else
Console.WriteLine("Рабочий день недели");
