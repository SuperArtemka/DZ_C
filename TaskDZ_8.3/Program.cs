// Программа, которая построчно выводит трехмерный массив неповторяющихся двузначных чисел, добавляя индексы каждого элемента.

void FillMatrixWhithRandomNumbers(int[,,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {


                matrix[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k],1} ({i},{j},{k}) \t");
                System.Console.WriteLine();
            }

        }
    }

}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество блоков массива: ");
int f = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[m, n, f];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
