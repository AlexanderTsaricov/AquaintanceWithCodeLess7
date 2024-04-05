/*
    Задайте значения M и N. Напишите программу, 
    которая выведет все натуральные числа в промежутке от M до N. 
    Использовать рекурсию, не использовать циклы.
*/

Console.WriteLine("Введите первое число:");
int firstInputNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondInputNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Диапазон натуральных чисел от {firstInputNum} до {secondInputNum}:");

void PrintRangeNum(int firstNum, int secondNum)
{
    if (firstNum > secondNum)
    {
        return;
    }
    if (firstNum > 0)
    {
        Console.Write($"{firstNum} ");
    }
    PrintRangeNum(++firstNum, secondNum);
}

PrintRangeNum(firstInputNum, secondInputNum);