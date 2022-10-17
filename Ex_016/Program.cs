// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N


Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());

int[] array = new int [num];

while(array[num] % 2 == 0)
{
    Console.Write(num);
    array[num] = array[num-1];
}



