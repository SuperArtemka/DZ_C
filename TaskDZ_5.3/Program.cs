// Разница между min и max в массиве вещественных чисел

double[] FillArrayWithRandomNumber(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.Next(1, 100) + rnd.NextDouble(), 2);
    }
    return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double difference = max - min;
System.Console.WriteLine(difference);
