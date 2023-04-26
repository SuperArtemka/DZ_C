// Поиск "min, max" из двух чисел
Console.Write("Введите певое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo){
    Console.WriteLine($"max = {numberOne} min = {numberTwo}");
}
else if(numberOne < numberTwo){
    Console.WriteLine($"max = {numberTwo} min = {numberOne}");
}
else {
 Console.Write("Они равны!");   
}