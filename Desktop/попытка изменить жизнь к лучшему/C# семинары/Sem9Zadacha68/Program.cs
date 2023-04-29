﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Ведите M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите N = ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0)
    Console.WriteLine("Вы ввели ненатуральное число(а)");
else
    Console.Write($"M = {M}; N = {N} -> {Ackerman(M, N)} ");

int Ackerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ackerman(n - 1, 1);
    if (n > 0 && m > 0) return Ackerman(n - 1, Ackerman(n, m - 1));
    return Ackerman(n, m);
}