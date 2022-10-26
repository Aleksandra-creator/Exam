// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y)

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool validateCoord(int X, int Y)
{
    if (X == 0 || Y == 0)
    {
        Console.WriteLine("Координаты находятся на осях Х и У");
        return false;
    }
    return true;
}

int GetQuarter (int X, int Y)
{
    if (X >= 1 && Y >= 1)
    {
        return 1;
    }
    if (X >= 1 && Y < 0)
    {
        return 2;
    }
    if (X >= 1 && Y < 0)
    {
        return 3;
    }
    return 4;
}
int x = Prompt("Введите X: ");
int Y = Prompt("Введите Y: ");

if (validateCoord(x, Y))
{
    int quarter = GetQuarter(x, Y);
    Console.WriteLine($"Номер четверти - {quarter}");
}