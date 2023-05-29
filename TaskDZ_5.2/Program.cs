// Сумма элементов нечетных позиций массива 
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}
System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
System.Console.WriteLine(string.Join(",", array));

int sum = 0;
for (int i = 1; i < array.Length; i+=2){

        sum+= array[i];
}
System.Console.WriteLine($"Сумма чисел нечетных позиций массива: {sum}");
