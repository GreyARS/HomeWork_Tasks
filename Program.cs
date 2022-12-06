/*
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.Write("This numbers is equal");
    }

else 

if (num1 > num2)
{
    Console.Write($"Number {num1} is bigger than number {num2}.");
}

else
{
    Console.Write($"Number {num2} is bigger than number {num1}.");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/*
Console.Write("Input the First number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the Second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the Third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.Write("Maximum number is: " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.Write($"The number {num} is even.");
}
else
{
    Console.Write($"The number {num} is NOT even.");
}
