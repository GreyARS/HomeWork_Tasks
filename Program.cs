/*
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool IsPal(int num)
{
    int rev_num = 0;

        while (num > 0) 
        {
            rev_num = rev_num * 10 + num % 10;
            num = num / 10;
        }
    
    if(num == rev_num)
    {
        Console.WriteLine("Yes, this number is a palindrom.");
        return true;
    }

    else
    {
        Console.WriteLine("No, this number is not a palindrom.");
        return false;
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool Palyndrom = IsPal(num);
*/


/*
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Range(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double lenght = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
    return lenght;
}

Console.Write("Введите координату точки А по оси X: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки А по оси Y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки А по оси Z: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки B по оси X: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double rangeAB = Range(xA, yA, zA, xB, yB, zB);
Console.Write("Range of AB = " + rangeAB);
*/


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeNumber(int num)
{
    int current = 1;
    int numCube = 0;

    while(num >= current)
    {
        numCube = Convert.ToInt32(Math.Pow(current, 3));
        Console.Write(numCube + " ");
        current++;
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

CubeNumber(num);
