// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Задайте значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


string FindNatureNumber( int m, int n)
{
 if( m == n) return n.ToString();
   else return m.ToString() + ", " + FindNatureNumber(m+=1, n);
}
Console.WriteLine (FindNatureNumber(numberM, numberN));

