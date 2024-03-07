//Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNum(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.Write($"{m} ");
    }
    PrintNum(m + 1, n);    
}
Console.WriteLine("Введите число равное M: ");
Console.WriteLine("Введите число равное N: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
PrintNum(m, n);
