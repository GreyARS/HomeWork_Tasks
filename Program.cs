/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ToDegree(int a, int b)

// Через цикл for:
{
    int result = 1;
    for(int count = 1; count <= b; count++)
    {
        result *= a;
    }
    return result;
}

// Либо через цикл while:
// {
//   int count = 1;
//   int res = 1;
//   while(count <= b)
//   {
//       res *= a;
//       count++;
//   }
//   return res;
//}

Console.Write("Input a Number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a Degree: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = ToDegree(a, b);
Console.Write($"{a} to the {b} degree is " + result);
*/



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumberSum(int num)
{
    int sum = 0;
    for(int element = 0; num > 0; element++)
    {
        element = num % 10;
        num = num / 10;
        sum += element;
    }
    return sum;
}

Console.Write("Input a Number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = NumberSum(num);
Console.Write($"The Sum of the elements of Number {num} is {result}");