// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = new int[5,5];
Random rnd = new Random();
InitMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
TheRowOfMinSum(matrix);

void InitMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,10);
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

void TheRowOfMinSum(int[,] matrix)
{
    int MinInRow = 0;
    int MinSum = 0;
    int Sum = 0;
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        MinInRow += matrix[0,i];
    }
    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        Sum += matrix[i,j];  
    if (Sum < MinInRow)
    {
        MinInRow = Sum;
        MinSum = i;
    }
    Sum = 0;
    }
    Console.Write($"Строка {MinSum + 1} содержит наименьшую сумму элементов");
}
