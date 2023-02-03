// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает 
// наибольшую цыфру числа.
// 78->8
// 12->2
// 85->8

Random rand = new Random();// Обьявление обьекта класса рандом
int randNumber = rand.Next(100, 1000);//.Next генерирует числа от (10 до 99) или больше
System.Console.WriteLine(randNumber);

if (randNumber/100 > randNumber%100)
{
    System.Console.WriteLine($"Большая цифра числа {randNumber}: { randNumber/100 }");
}
else
{
    System.Console.WriteLine($"Большая цифра числа {randNumber}: { randNumber%100 }");
}

