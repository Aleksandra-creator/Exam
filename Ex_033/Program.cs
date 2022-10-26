// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetQuarter (int x, int Y)
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