int num = new Random().Next(1, 20);
Console.WriteLine("Сгенерированное число = " + num);
int firstEl = 1;
void PrintNum(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write($"{start} ");
    PrintNum(++start, end);
}

PrintNum(firstEl, num);