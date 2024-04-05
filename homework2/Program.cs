/*
    Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n.
    Ответ: Исходя из формулы, что я нашел
    Формула:
    А(0, т) = n+1
    A(m, 0) = A(m-1, 1)
    A(m, n) = A(m-1, A(m, n-1)),
    где насколько я понял, если не 0, значит
    больше 0
*/

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
Console.WriteLine(AkkermanFunction(1, 2));

