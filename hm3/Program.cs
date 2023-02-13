// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.WriteLine("Введите данные для опредения матрицы: ");
int a = InputNumbers("Введите колличество строк 1ой матрицы: ");
int b = InputNumbers("Введите колличество строк 2ой матрицы: ");
int c = InputNumbers("Введите число столбцов матриц: ");
int diapason = InputNumbers("Введите максимальное значение заполнения матрицы; ");
Random rnd = new Random();

int[,] firstMartrix = new int[a, b];
CreateArray(firstMartrix);
Console.WriteLine($"Матрица №1:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[b, c];
CreateArray(secomdMartrix);
Console.WriteLine($"Матрица №2:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[a,c];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
WriteArray(resultMatrix);

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(diapason);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int z = 0; z < firstMartrix.GetLength(1); z++)
      {
        sum += firstMartrix[i,z] * secomdMartrix[z,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}