Console.WriteLine("Введите число");
int userNum = Convert.ToInt32(Console.ReadLine());

int GetSumNum(int num)
{
    if (num <= 0)
    {
        return 0;
    }

    return num % 10 + GetSumNum(num / 10);
}



Console.WriteLine(GetSumNum(userNum));