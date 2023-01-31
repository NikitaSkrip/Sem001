// dotnet -проверка, все ли установленно
// dotnet new console - создание проэкта
// dotnet run - запуск проекта

Console.Write("Ввеите целое число: ");// вывод в консоль сообщение
int number = Convert.ToInt32(Console.ReadLine());// int.Parse() или Convert.ToInt32()
int sqr = number * number;
System.Console.WriteLine($"Квадрат числа: {sqr} ");// Упращенный вариант в начале пишем ($"Текст: {});
// System.Console.WriteLine("Квадрат числа: " + sqr); Обычный вариант