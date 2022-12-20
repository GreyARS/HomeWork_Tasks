/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int NumElement(int size)
{
    int count = 0;
    for(int i = 0; i < size; i++)
    {  
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    }
    return count;
}

Console.Write("Input number of Elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int result = NumElement(size);
Console.Write("Number of positive elements is " + result);
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CheckPoint(double b1, double k1, double b2, double k2)
{
    if((k1 == k2 && b1 == b2))
    {
        Console.WriteLine("Прямые совпадают (любая из точек является пересечением).");
    }

    else if(k1 == k2)
    {
        Console.WriteLine("Прямые параллельны (нет точек пересечения).");
    }

    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения этих двух прямых находится в координатах {x}, {y}.");
    }
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

CheckPoint(b1, k1, b2, k2);