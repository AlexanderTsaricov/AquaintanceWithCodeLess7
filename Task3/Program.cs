Console.WriteLine("Ввести строку");
string userInput = Console.ReadLine();

string vowels = "aeiouy";
int i = 0;
void PrintStr(int numEl, string str)
{
    if (numEl >= str.Length)
    {
        return;
    }
    if (!vowels.Contains(str[numEl]))
    {
        Console.Write(str[numEl] + " ");
    }
    PrintStr(++numEl, str);
}

PrintStr(i, userInput);