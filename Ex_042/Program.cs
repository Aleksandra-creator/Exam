// Напишите программу, которая генерирует последовательность случайных чисел из 10 элементов 
// в диапазоне от 1 до 10, и подсчитывает, сколько сгенерировалось чисел больше 5.



void GenNum (int[] args)
{
    int nums = new Random().Next(1, 10);
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine (nums);
    }
}

var nums = GenNum(10);
if (nums >= 5)
{
    Console.WriteLine (nums);
}