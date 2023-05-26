// Сумма цифр в числе

System.Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int digitCount = 0;
while (digit != 0)
{
    digitCount += digit % 10;
    digit /= 10;
}
System.Console.WriteLine($"Сумма цифр числа {digit} равна {digitCount}");