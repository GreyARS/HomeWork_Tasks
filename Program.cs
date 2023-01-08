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