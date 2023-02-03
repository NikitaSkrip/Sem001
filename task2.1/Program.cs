// Напишите программу которая будет принемать на входе два числа и выводить является ли второе число кратное первому.
// Если число 2 не кратное число 1, то программа остаток от деления.
// 34,5 остаток 4
// 16,4 кратно


System.Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int remainder = ( firstnumber % secondnumber );

if (remainder == 0)
{
    System.Console.WriteLine($"Первое число кратное второму числу {remainder}");
}
else
{
    System.Console.WriteLine($"Не кратно, остаток  { remainder }");
}

