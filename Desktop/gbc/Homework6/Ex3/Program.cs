void printArray(int[] array, int lenght)
{
    Console.Write("[");
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(" " + array[i]);
    }
        Console.Write("]");
}

//Запросить сколько чисел генерить в массив (n)
Console.WriteLine("введите, сколько чисел генерить в массиве");
int lenght = Convert.ToInt32(Console.ReadLine());

//Создаем пустой массив на n
int [] array = new int[lenght];

//Генерим n чисел и помещаем в массив
for (int i = 0; i < lenght; i++)
{
    int digit = new Random().Next(0, 99);
    array[i] = digit;
}

int sum = 0;

for (int i = 0; i < lenght/2; i++)
{
    int prod = 1;
    prod = array[i] * array[lenght-1-i];
    sum = sum + prod;
    Console.WriteLine(" ");
}

//Вывести массив
 printArray(array, lenght); 

Console.WriteLine(" -> " + sum);
