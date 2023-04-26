// Определение "min" и "max" из трех чисел.

Console.Write("Введите первое число :");
int numOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int numTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число :");
int numThree = Convert.ToInt32(Console.ReadLine());

if(numOne > numTwo && numTwo > numThree){
    Console.Write($"max = {numOne} min = {numThree}");
}
else if(numOne < numTwo && numOne > numThree){
    Console.Write($"max = {numTwo} min = {numThree}");
}
else if(numOne < numThree && numOne > numTwo){
    Console.Write($"max = {numThree} min = {numTwo}");
}
else if(numTwo < numThree && numOne < numTwo){
    Console.Write($"max = {numThree} min = {numOne}");
}
else{
    Console.Write("Они равны!");
}