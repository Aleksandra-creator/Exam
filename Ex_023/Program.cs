// Напишите программу, которая выводит случайное число из отрезка [10, 9999] 
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 10000);
Console.WriteLine(number);
int maxDigit = number % 10;

while(number > 0)
{
    int temp = number % 10;
    if (temp < number % 10) {maxDigit = temp; }
    number = number / 10;
}

Console.WriteLine(maxDigit);
