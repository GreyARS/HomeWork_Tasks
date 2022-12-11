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