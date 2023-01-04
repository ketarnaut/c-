/*

Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

[1,7] -> такого числа в массиве нет
*/

void FillAndPrintArray(int [,] array)
{
    Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = rnd.Next(1,99);  
                Console.Write(array[i, j] +  " ");
            }
            Console.WriteLine();
        }
}

Console.WriteLine("введите кол-во строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите кол-во столбов в массиве");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];


FillAndPrintArray(array);

Console.WriteLine("Укажите индекс строки для поиска");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите индекс столбца для поиска");
int j = Convert.ToInt32(Console.ReadLine());

Console.Write("[ " + i + ", " + j + " ] --> ");

if (i < array.GetLength(0) && j < array.GetLength(1)) 
{
    Console.WriteLine(array[i,j]);
}

else 
{
    Console.WriteLine("Такого числа в массиве нет");
}



