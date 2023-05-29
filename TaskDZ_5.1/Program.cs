// Количество четных чисел в массиве случайных трехзначных чисел

int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 1000);
}
return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));
int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
{
count++;
}
}
System.Console.WriteLine($"Количество четных чисел в массиве: {count}");

