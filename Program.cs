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

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNum(int num)
{
    if(num < 100)
    {
        return -1;
    }

    if(num > 999)
    {
        while(num > 999)
        {
            num = num / 10;
        }
    }
    
    int thirdNum = num % 10;
    return thirdNum;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ThirdNum(num);

if(result < 0)
{
    Console.WriteLine($"В числе {num} нет третьей цифры.");
}

else
{
    Console.WriteLine($"Третья цифра числа {num} - {result}.");
}
*/
