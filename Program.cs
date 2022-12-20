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