/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void SortArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
      for(int k = 0; k < array.GetLength(1) - 1; k++)
        if(array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array, int min, int max)
{
  for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(min, max);
}

void WriteArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int min = InputNumbers("Введите минимальное значение: ");
int max = InputNumbers("Введите максимальное значение: ");

int[,] array = new int[m,n];
CreateArray(array, min, max);
WriteArray(array);

Console.WriteLine("Отсортированный массив: ");
SortArray(array);
WriteArray(array);
*/


/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for(int j = 1; j < array.GetLength(1); j++)
    sumLine += array[i,j];  
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array, int min, int max)
{
  for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(min, max);
}

void ShowArray(int[,] array)
{
  Console.WriteLine();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int min = InputNumbers("Введите минимальное значение: ");
int max = InputNumbers("Введите максимальное значение: ");

int[,] array = new int[m, n];
CreateArray(array, min, max);
ShowArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);

for(int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumLineElements(array, i);
  if(sumLine > temp)
  {
    sumLine = temp;
    minSumLine = i;
  }
}
Console.WriteLine();
Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой элементов({sumLine}).");
*/


/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for(int i = 0; i < resultMatrix.GetLength(0); i++)
    for(int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for(int k = 0; k < firstMartrix.GetLength(1); k++)
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
    resultMatrix[i,j] = sum;
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array, int range)
{
  for(int i = 0; i < array.GetLength(0); i++)
    for(int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(range + 1);
}

void ShowArray(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапозон значений от 1 до: ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix, range);
Console.WriteLine("Первая матрица:");
ShowArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix, range);
Console.WriteLine("Вторая матрица:");
ShowArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение матриц:");
ShowArray(resultMatrix);
*/


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void ShowArray(int[,,] array3D)
{
  for(int i = 0; i < array3D.GetLength(0); i++)
    for(int j = 0; j < array3D.GetLength(1); j++)
    {
      for(int k = 0; k < array3D.GetLength(2); k++)
        {
          Console.Write($"{array3D[i,j,k]} ({i},{j},{k}); ");
        }
      Console.WriteLine();
    }
  Console.WriteLine();
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for(int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    
    if(i >= 1)
      for(int j = 0; j < i; j++)
      {
        while(temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
        number = temp[i];
      }
  }
  
  int count = 0; 
  for(int x = 0; x < array3D.GetLength(0); x++)
    for(int y = 0; y < array3D.GetLength(1); y++)
      for(int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
}

Console.WriteLine("Введите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
ShowArray(array3D);