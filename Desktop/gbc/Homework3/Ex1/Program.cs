/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void DefinePalindrom(int number)
{
    if (((number % 10) == (number / 10000)) && ((number % 100) / 10) == ((number / 1000) % 10)) 
    {
     Console.WriteLine("да");
    }
    else 
    {
     Console.WriteLine("нет");
    }

}


Console.WriteLine("Введите пятизначное число и я определю, палиндром ли оно");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Число не пятизначное, введите еще раз!");
}
else 
{
DefinePalindrom(number);
}