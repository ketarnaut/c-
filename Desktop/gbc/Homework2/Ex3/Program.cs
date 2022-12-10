/*
Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit % 7 == 0 && digit % 23 == 0)
{
    Console.WriteLine("да");
}

else 
{
    Console.WriteLine("нет");
}