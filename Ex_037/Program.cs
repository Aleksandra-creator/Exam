// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int N = Prompt("Введите любое число: ");

for (int count = 1; count <= N; count++)
{
    int res = (count * count);
    Console.WriteLine (res);
}
