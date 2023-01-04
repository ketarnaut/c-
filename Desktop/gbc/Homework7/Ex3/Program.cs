/*
Задача 3. Необязательная, дополнительная задача Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0). Полученные средние арифметические занести в одномерный массив.

Например, задан массив:

100 404 504 225
550 478 800 363
505 101 410 479
=> [505, 252.5, 0, 363 ]
*/


Console.WriteLine("введите кол-во строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите кол-во столбов в массиве");
int col = Convert.ToInt32(Console.ReadLine());


if ((row*col) < 100)
{
    Console.WriteLine("Нужно более 100 элементов");
}


else {

int[,] array = new int[row, col];

FillAndPrintArray(array);
FindPalindromsAndCountAverage(array);
}



void FillAndPrintArray(int [,] array)
{
    Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = rnd.Next(100,999);  
                Console.Write(array[i, j] +  " ");
            }
            Console.WriteLine();
        }
}

void FindPalindromsAndCountAverage(int [,] array)
{
    //Создать одномерный массив длиной как кол-во столбов
    int [] arrayOfNumber = new int[col];
                
    for (int j = 0; j < row; j++)
        { 
            int sum = 0;
            int count = 0;
            for (int i = 0; i < col; i++)
            {
                //Проверям палиндром ли число и плюсуем если да и считаем
                if ((array[i,j] % 10) == (array[i,j] / 100)) 
                {
                    //Console.WriteLine("Сумма до сложения = " + sum);
                    sum = sum + array[i,j];
                    //Console.WriteLine("Сумма после = " + sum);
                    count ++; 
                    //Console.WriteLine("Количество палиндромов = " + count);

                }
            if ( count != 0)
            {
            arrayOfNumber[j] = sum / count; 
            }   
            
            }
            //Выводим получившийся одномерный массив
            Console.Write(arrayOfNumber[j] + ", ");
        }
}