/*
    Задайте произвольный массив. 
    Выведете его элементы, начиная с конца. 
    Использовать рекурсию, не использовать циклы.
*/
int i = 0;
Random rnd = new Random();
int[] FillingArray(int[] arr, int i)
{
    if (i >= arr.Length)
    {
        return arr;
    }
    arr[i] = rnd.Next(1, 10);
    return arr = FillingArray(arr, ++i);
}

int[] array = new int[10];
array = FillingArray(array, i);

int endNum = array.Length - 1;
int firstNum = 0;

void FlipPrintArray(int[] arr, int endNum)
{
    if (endNum < 0)
    {
        return;
    }
    Console.Write($"{arr[endNum]} ");
    FlipPrintArray(arr, --endNum);
}

void PrintArray(int[] arr, int firstNum)
{
    if (firstNum >= arr.Length)
    {
        return;
    }
    Console.Write($"{arr[firstNum]} ");
    PrintArray(arr, ++firstNum);
}

Console.WriteLine("Рандомный массив:");
PrintArray(array, firstNum);
Console.WriteLine();
Console.WriteLine("Перевернутый массив:");
FlipPrintArray(array, endNum);