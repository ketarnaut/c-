/*
Задача 1
Напишите цикл, который принимает на вход 2 числа и возводит число А в натуральную степень B

*/

Console.WriteLine("Введите число для возведения в степень");
int A = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите в какую степень будете возводить");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < B; i++)
{
    result = result * A;
}

Console.WriteLine(result);


