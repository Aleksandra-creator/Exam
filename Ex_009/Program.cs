// На вход принимает 2 числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// а = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.Write ("Введите первое число:");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.Write("Введите второе число:");
int secondNum = int.Parse(Console.ReadLine());

if (firstNum * firstNum == secondNum)
{
    Console.Write("True");
}
else
{
    Console.Write("False");
}