// Вывод третьего числа, если оно есть
Console.WriteLine("Введите трехзначное число : ");
string number = Console.ReadLine();
int numberLenght = number.Length;

if (numberLenght > 2)
{
    Console.WriteLine($"Третья цифра этого числа это: {number[2]}");
}
else
{
    Console.WriteLine("Это число меньше трехзначного");
}

