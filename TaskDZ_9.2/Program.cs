// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumDigital(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        return SumDigital(m + 1, n) + m;
    }


}

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма элементов в промежутке от M до N: {SumDigital(m, n)}");