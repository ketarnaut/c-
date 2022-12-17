/* Задача 1 Зайдайте массив заполненных случайными положительными трехзначными числами.
Программа должна показать количество четных чисел в массиве
*/

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
int count = 0;


//Создаем пустой массив на n
int [] arrayOfNumber = new int[lenght];

//Генерим n чисел и помещаем в массив
//CreateNewArray(lenght, arrayOfNumber[lenght]);
for (int i = 0; i < lenght; i++)
    {
        int digit = new Random().Next(100, 999);
        arrayOfNumber[i] = digit;
    }

//проверяем каждое число в массиве и считаем четные

for (int i = 0; i < lenght; i++)
    {
        if (arrayOfNumber[i] % 2 == 0)
        {
            count++;
        }
    }  

//Вывести массив
 printArray(arrayOfNumber, lenght); 

Console.WriteLine(" --> " + count);