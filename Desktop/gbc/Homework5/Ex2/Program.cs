/*Задача 2 Зайдайте массив заполненных случайными числами.
Программа должна показать сумму нечетных элементов

*/

//Запросить сколько чисел генерить в массив (n)
Console.WriteLine("введите, сколько чисел генерить в массиве");
int lenght = Convert.ToInt32(Console.ReadLine());
int sum = 0;

//Создаем пустой массив на n
int [] arrayOfNumber = new int[lenght];

//Генерис n чисел и помещаем в массив
//CreateNewArray(lenght, arrayOfNumber[lenght]);
for (int i = 0; i < lenght; i++)
    {
        int digit = new Random().Next(100, 999);
        arrayOfNumber[i] = digit;
    }

//проверяем каждое число в массиве и суммируем нечетные
//CheckOfArray(lenght, arrayOfNumber[lenght]);

for (int i = 0; i < lenght; i++)
    {
        if (arrayOfNumber[i] % 2 == 1)
        {
            sum = sum + arrayOfNumber[i];
        }
    }  

//выводим массив

    Console.Write("[");

    for (int i = 0; i < lenght; i++)
    {
        Console.Write(" " + arrayOfNumber[i]);
    }
        Console.Write("]");

        Console.WriteLine(" --> " + sum);