// // Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y)

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int quarter = Prompt ("Введите номер четверти: ");
bool validateCoord (int quarter);
if (quarter > 0 && quarter < 5)
{
    return true;
}
return false;

(int, int) FindCoords (int quarter)
{
    if (quarter == 1) return (1, 1);
    if (quarter == 2) return (1, -1);
    if (quarter == 3) return (-1, -1);
    return (-1, 1);
}
if (validateCoord(quarter))
{
    (int X, int Y) = FindCoords (X, Y);
    Console. WriteLine ($"Для четверти {quarter} используйте координаты {x} и {y}");
}
else
{
    Console. WriteLine ($"Введено некорректное значение");
}
