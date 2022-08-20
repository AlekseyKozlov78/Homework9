// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Console.Write("Введите неотрицательное число m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите неотрицательное число n = ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Функция Аккермана равна {AkkermanFunction(m, n)}");