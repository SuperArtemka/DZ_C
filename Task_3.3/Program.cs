// Возведение в куб числа от 1 до N 

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}
