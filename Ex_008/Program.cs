

System.Console.Write ("Введите число:"); // Выводим подсказку на экран
string inputString = Console.ReadLine(); // Получаем введенную строку 
int value = Convert.ToInt32(inputString); // Преобразуем к целому типу

int square = value * value; // Вычисляем квадрат
System.Console.WriteLine(square); // Выводим значение в консоль
