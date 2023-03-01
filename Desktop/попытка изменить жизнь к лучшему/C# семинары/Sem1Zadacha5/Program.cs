Console.Write("Введите натуральное число:");
int number=Convert.ToInt32(Console.ReadLine());
int Chetchic = -number;
if (number>0)
{
     while (Chetchic<=number)
    {
        Console.Write(Chetchic);
        Chetchic=Chetchic+1; 
    }
}
else
{
  Console.Write("Введуно ненатуральное число:");  
}

