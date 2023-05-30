int Prompt(string message)
{
    Console.Write(message);
    int num11 = int.Parse(Console.ReadLine()!);
    return num11;
}

int x1 = Prompt("Введите координату Х точки А ");
int y1 = Prompt("Введите координату Y точки А ");
int z1 = Prompt("Введите координату Z точки A ");

int x2 = Prompt("Введите координату Х точки B ");
int y2 = Prompt("Введите координату Y точки B ");
int z2 = Prompt("Введите координату Z точки B ");


void CalculateDistanse(int x1, int y1, int x2, int y2, int z1, int z2)
{
double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine("Расстояние между точками: " + d);
}

CalculateDistanse(x1, y1, x2, y2, z1, z2);

