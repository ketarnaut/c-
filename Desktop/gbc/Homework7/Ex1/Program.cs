/*
Задать двумерный массив размером m*n, заполненны случайными вещественными числами
тип данных double
*/

void FillArray(double [,] array)
{
    Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = Math.Round((rnd.Next(1, 100) + rnd.NextDouble()),2);
                Console.Write(array[i, j] +  " ");
            }
            Console.WriteLine();
        }
}


Console.WriteLine("введите кол-во строк в массиве");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите кол-во столбов в массиве");
int col = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[row, col];


FillArray(array);


