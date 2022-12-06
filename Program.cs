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
