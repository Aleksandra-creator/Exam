// Напишите программу, которая будет принимать на вход пять чисел и 
// выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = Prompt(message: "Введите первое число: ");
int b = Prompt(message: "Введите второе число: ");
int c = Prompt(message: "Введите третье число: ");
int x = Prompt(message: "Введите четвертое число: ");
int y = Prompt(message: "Введите пятое число: ");

// int DivBy (int a, int b, int c, int x, int y)

int sum = a + b + c + x + y;
double average = (sum / 5.0);
Console.WriteLine($"Сумма равна {sum}, а среднее арифметическое равно {average}");

