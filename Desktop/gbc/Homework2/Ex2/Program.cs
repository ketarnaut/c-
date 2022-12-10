/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.WriteLine("Введите число и я вернуть третью цифру");

int number = Convert.ToInt32(Console.ReadLine());


if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}

else if (number < 1000)
{
    int secondDigital = number % 10;
    Console.WriteLine("Третья цифра числа = " + secondDigital);
}

else if (number < 10000)
{
    int secondDigital = (number % 100) / 10;
    Console.WriteLine("Третья цифра числа = " + secondDigital);
}

else if (number < 100000)
{
    int secondDigital = (number % 1000) / 100;
    Console.WriteLine("Третья цифра числа = " + secondDigital);
}

else 
{
     Console.WriteLine("Число слишком большое, я не умею =(");
   
}