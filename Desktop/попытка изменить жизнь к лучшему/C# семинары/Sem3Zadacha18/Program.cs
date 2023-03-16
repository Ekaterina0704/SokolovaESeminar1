Console.Write($"Введите номер четверти: ");
int quarter= Convert.ToInt32(Console.ReadLine());

string Range(int x)
{
    if (x==1) return "(x>0 && y>0)";
    if (x==4) return "(x>0 && y<0)";
    if (x==2) return "(x<0 && y>0)";
    if (x==3) return "(x<0 && y>0)";
    return "некорректное значение";
}
string range = Range(quarter);
Console.WriteLine($"Заданой четверти соответствует диапазон: {range}");     
