// напишите программу,которая выводит любое трехзначное число, и удаляет вторую цифру этого числа.

// пример
// 456->46
// 782->72
// 918->98

Random rand = new Random();// Обьявление обьекта класса рандом
int randNumber = rand.Next(100, 1000);//.Next генерирует числа от (10 до 99) или больше
System.Console.WriteLine(randNumber);

System.Console.WriteLine($"Удаление второй цифры данного числа {randNumber}: { randNumber/100 *10 + randNumber%10 }");
