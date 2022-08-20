// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNatureNumbers(int m, int n)
{
    if (m == n) return n;
    else return m + SumNatureNumbers(m += 1, n);
}

Console.Write("Введите положительное число M = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число N, которое больше M, N = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {SumNatureNumbers(m, n)}");
