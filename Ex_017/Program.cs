// Запись массивами
int[] array = {1, 3, 9, 4, 55, 6, 55};
int n = array.Length;
int find = 55;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}