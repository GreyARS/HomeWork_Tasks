/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] NewArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
                array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
    return array;
}

void ShowArray(double[,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
        for(int j = 0; j < myArray.GetLength(1); j++)
            Console.Write(myArray[i,j] + "\t");
        Console.WriteLine();
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = NewArray(rows, columns, minValue, maxValue);
ShowArray(myArray);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] myArray)
{
    Console.Write("Input row Element: ");
    int rowElement = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input column Element: ");
    int columnElement = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
            Console.Write(myArray[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();

    if (rowElement < myArray.GetLength(0) && columnElement < myArray.GetLength(1)) 
        Console.WriteLine($"The Element at row {rowElement} and column {columnElement} is {myArray[rowElement, columnElement]}");
    else Console.WriteLine("Data entry error!");
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);