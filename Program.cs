/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int MiddleNum(int num)
{
    int mid = num % 100 /10;

    return mid;
}

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int middle = MiddleNum(num);
Console.Write("Вторая цифра трёхзначного числа - " + middle);
*/