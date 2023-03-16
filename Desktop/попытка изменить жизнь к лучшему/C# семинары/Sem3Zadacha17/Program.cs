Console.WriteLine($"Введите координаты точки");
Console.Write("Х: ");
int xCoord= Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoord= Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if(x>0 && y>0) return 1;
    if(x>0 && y<0) return 4;
    if(x<0 && y>0) return 2;
    if(x<0 && y>0) return 3;
    return 0;
}

int quarter=Quarter(xCoord, yCoord);
string result =  quarter>0
                ? $"указанные координаты соответствуют {quarter}" 
                :  "введены некорректные координаты";
Console.WriteLine(result);     

