Console.WriteLine("Введите число: ");
int numMy123 = int.Parse(Console.ReadLine()!);
    
int first1 = numMy123 % 10;
int second2 = first1 % 10;
int third3 = second2 % 10;
int fourth4 = third3 % 10;
int fifth5 = fourth4 % 10;

void FindPall(int first1, int second2, int third3, int fourth4, int fifth5)
{
    Console.WriteLine($"{fifth5}{fourth4}{third3}{second2}{first1}");

    if (fifth5 == first1 && fourth4 == second2)
{
    Console.WriteLine("Данное число является паллиндромом!!!");
}
    else 
{
    Console.WriteLine("Error");
}
}
int number = numMy123;
FindPall(number);
