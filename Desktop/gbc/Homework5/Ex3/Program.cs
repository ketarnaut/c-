/*
Задайте массив вещественных чисел
Найдите разницу между максимальным и минимальным числом массива
*/

//Создать массив чисел
int[] CreateRandomArray(int lenght)
{
    int[] array = new int[lenght];
    Random rnd = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = rnd.Next(1, 100000);
    }
    return array;
}

//
void printArray(int[] array, int lenght)
{
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(" " + array[i]);
    }
        Console.Write("]");

        Console.WriteLine(" --> ");
}

//Запросить сколько чисел генерить в массив (n)
Console.WriteLine("введите, сколько чисел генерить в массиве");
int lenght = Convert.ToInt32(Console.ReadLine());

//Генериуем и заполняем массив на n элементов
int[] array = CreateRandomArray(lenght);

//Вывести массив
 printArray(array, lenght); 

//Найти максимальное и минимальное
int max = array[0];
int min = array[1];

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