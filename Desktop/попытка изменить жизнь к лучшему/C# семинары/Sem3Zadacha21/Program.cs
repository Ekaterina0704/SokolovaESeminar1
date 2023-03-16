Console.WriteLine($"Введите координаты первой точки");
Console.Write("Х1: ");
int x1Coord= Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Coord= Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1Coord= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите координаты второй точки");
Console.Write("Х2: ");
int x2Coord= Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coord= Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2Coord= Convert.ToInt32(Console.ReadLine());


double Distance(int x1,int y1,int x2,int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}

double distance=Distance(x1Coord,y1Coord,x2Coord,y2Coord,z1Coord,z2Coord);
double resRound=Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 3D постранстве = {Math.Round(distance, 2, MidpointRounding.ToZero)}");