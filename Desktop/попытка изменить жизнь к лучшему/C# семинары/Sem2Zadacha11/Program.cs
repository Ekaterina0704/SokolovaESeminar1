int number = new Random().Next(100,1000);
Console.WriteLine($"Рандомное трехзначное число -> {number}");
// int firstDigit=number/100;
// int thirdDigit=number%10;
// Console.Write(firstDigit);
// Console.WriteLine(thirdDigit);
int twodigitnumber=Twodigitnumber(number);
Console.WriteLine($"Составное двузначное число -> {twodigitnumber}"); 

int Twodigitnumber(int num)
{
    int firstDigit=num/100;
    int thirdDigit=num%10;
    int result=firstDigit*10+thirdDigit;
    return result;
}