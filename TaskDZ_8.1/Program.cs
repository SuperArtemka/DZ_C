// Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void OrderedMatrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)

                if (matrix[i, x] < matrix[i, x+1])
                {
                    temp = matrix[i, x+1];
                    matrix[i, x+1] = matrix[i, x];
                    matrix[i, x] = temp;
                }

        }
    }

}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
OrderedMatrix(matrix);
PrintMatrix(matrix);