// Значение элемента массива по принимаемым на ввод позициям


void FillMatrixWhithRandomNumbers(int[,] matrix, int x, int y)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
            
        }
    }
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} " + "\t");
}
System.Console.WriteLine();
}
}


System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

System.Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());


FillMatrixWhithRandomNumbers(matrix, x, y);
PrintMatrix(matrix);

if (x > 0 && x < m && y > 0 && y < n)
    System.Console.WriteLine($"Значение заданного элемента: {matrix[x, y]}");
else
{
    System.Console.WriteLine($"Вводимые координаты не соответствуют размеру массива");
}
