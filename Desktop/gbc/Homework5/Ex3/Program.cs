/*
Задайте массив вещественных чисел
Найдите разницу между максимальным и минимальным числом массива
*/

//Создать массив чисел
double[] CreateRandomArray(int lenght)
{
    double[] array = new double[lenght];
    Random rnd = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = Convert.ToDouble(rnd.Next(10000)/100.0);
    }
    return array;
}

//
void printArray(double[] array, int lenght)
{
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(" " + array[i],2);
    }
        Console.Write("]");

        Console.WriteLine(" --> ");
}

//Запросить сколько чисел генерить в массив (n)
Console.WriteLine("введите, сколько чисел генерить в массиве");
int lenght = Convert.ToInt32(Console.ReadLine());

//Генериуем и заполняем массив на n элементов
double[] array = CreateRandomArray(lenght);

//Вывести массив
printArray(array, lenght); 

//Найти максимальное и минимальное
double max = array[0];
double min = array[1];

for (int i = 2; i < lenght; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
} 

//Посчитать и вывести результат
Console.WriteLine(max - min);  