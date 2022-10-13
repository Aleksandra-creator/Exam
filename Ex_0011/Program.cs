// напишите программу по модуля числа

Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
int mod = number;
if (number < 0)
{
    mod = -number;
}
Console.WriteLine(mod);