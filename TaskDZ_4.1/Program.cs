//Цикл возведения в степень числа

System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Degree(int A, int B)
{
    int count = 1;
    for (int i = 0; i < B; i++)
    {
        count *= A;
    }
    return count;
}
int count = Degree(A,B);
 System.Console.WriteLine($"Число {A} в степени {B} равно = {count}");
