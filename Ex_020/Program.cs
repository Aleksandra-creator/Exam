// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа

int number = new Random().Next(10, 99);

int lastDigit = number % 10;
int firstDigit = number / 10;

if (LastDigit > FirstDigit)
Console.WriteLine(LastDigit);

else
{
    Console.WriteLine(FirstDigit);
}

