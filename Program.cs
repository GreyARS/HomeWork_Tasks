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