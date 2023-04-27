// Соответствует ли введенное число выходному дню
Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Это выходной день!");
}
else if (day <= 5)
{
    Console.WriteLine("Это не выходной");
}
else
{
    Console.WriteLine("Введите число от 1 до 7!");
}