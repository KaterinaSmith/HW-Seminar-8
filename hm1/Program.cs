// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] matrix = new int[5,5];
Random rnd = new Random();
InitMatrix(matrix);
PrintMatrix(matrix);
SortMaxToMin(matrix);

Console.WriteLine();

PrintMatrix(matrix);

void InitMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }
}
void SortMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(1)-1; z++)
            {
                if (matrix[i, z] < matrix[i, z+1])
                {
                    int tt = matrix[i, z+1];
                    matrix[i, z+1] = matrix[i, z];
                    matrix[i, z] = tt;
                }
            }
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}