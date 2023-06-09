// Программа, которая будет находить строку с наименьшей суммой элементов в двумерном массиве.

void FillMatrixWhithRandomNumbers(int[,] matrix)
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

void MatrixWithMinSumRow(int[,] matrix)
{
    int k =0;
    int minsum = 0;
 for (int i = 0; i < matrix.GetLength(1); i++)
    {int sum =0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[i, j];
        }
        if (i==0){
            minsum = sum;
        }
        else if(sum < minsum){
            minsum = sum;
            k = i;
        }
        
    }System.Console.WriteLine($"Строка с наименьшей суммой: {k+1}");
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
MatrixWithMinSumRow(matrix);
