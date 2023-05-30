int Prompt(string message)
{
    Console.Write(message);
    string num11 = Console.ReadLine()!;
    

// Проверка

if ((int.TryParse(num11, out int num_n))== false)
{
    Console.WriteLine("Это не число: ");
    
}

return num_n;
}

void PrintDegree(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i,3) + " ");
    }
}
int num11 = Prompt("Введите число N: ");
int number = Math.Abs(num11);
PrintDegree(number);

