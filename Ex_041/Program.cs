// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Без использования строк
// 14212 -> нет
// 12821 -> да

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt ("Введите пятизначное число: ");

if (number <= 10000 && number >= 100000)
{
    Console.WriteLine ($"Число не является пятизначным");
}

int [] array = 
//if (number >= 10000 && number <= 100000)
//{
//    for (int i = 0; i <= 4; i++)
//    {
//       if (i=0 == i=4 && i=1 == i=3)
//       {
//        Console.WriteLine ($"Число {number} является палиндромом");
//       }
//       Console.WriteLine ($"Число {number} не является палиндромом");
//    }
//}

void CheckArray(int[] array)
{
    for (int i = 0; i <= 4; i++)
    {
        int [] NewArray = Array.Reverse(number);
        if (array = NewArray)
        {
            Console.WriteLine ($"Число {number}является палиндромом");
        }
        Console.WriteLine ($"Число {number}не ялвяется палиндромом");
    }
}

