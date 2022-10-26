// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int x1= Prompt ("Введите координаты X первой точки: ");
int y1= Prompt ("Введите координаты Y первой точки: ");
int x2= Prompt ("Введите координаты X второй точки: ");
int y2= Prompt ("Введите координаты Y второй точки: ");

// int distance = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
// double res = Math.Sqrt (distance);

// Console.WriteLine (res);

int X = x2 - x1;
int Y = y2 - y1;

double res = Math.Sqrt (X * X + Y * Y);
Console.WriteLine ($"Расстояние между координатами равно {res: f2}");