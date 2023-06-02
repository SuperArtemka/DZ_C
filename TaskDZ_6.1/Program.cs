// Количество четных элементов массива введенных с клавиатуры


int[] FillArrayNumber(int size)
{
int[] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
{
System.Console.Write("Введите элемент массива: ");
arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayNumber(length);
System.Console.WriteLine(string.Join(", ", array));

int temp = 0;

for (int i = 0; i < array.Length; i++)
{
if(array[i]%2==0){
    temp++;
}
}

System.Console.WriteLine($"Количество четных чисел: {temp}");