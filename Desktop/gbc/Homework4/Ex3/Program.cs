/*
Задача 3
Назовем число интересным, если его произведение цифр делится на сумму
Напишите программу, которая заполняет массив на 10 интересных случайных целых чисел от 10 до 1000
Каждый элемент массива сгенерирован случайно
*/

int GetSize (int digit)
{
    int count = 0;
    while (digit > 0)
    {
        digit = digit / 10;
        count++;
    }
    return count;
}


//Создаем пустой массив
int lenght = 10;
int [] digitsOfNumber = new int[lenght];


//в цикле проверям что еще не набралось 10 чисел и идем к след числу
for (int j = 0; j < lenght; )
{
    //генерируем новое число
    int digit = new Random().Next(10, 1000);
    int digit2 = digit;

 //проверяем что число "интересное" 
   
    //Посчитать длину числа  
    int lenghtOfsize = GetSize(digit);

    // создание массива
    int [] arrayOfNumber = new int[lenghtOfsize];

    //заполнение массив цифрами
    for (int i = 0; i < lenghtOfsize; i++)
    {
        arrayOfNumber[i] = digit2 % 10;
        digit2 = digit2 / 10;
    }


//перебирfем каждый элемент массива и считаем сумму и произведение
    int sum = 0;
    int prod = 1;
    for (int i = 0; i < lenghtOfsize; i++)
    {
        sum = sum + arrayOfNumber[i];
        prod = prod + arrayOfNumber[i];
//Если число интересное - добавляем в массив

    }
            if ((prod / sum) % 1 == 0){
            digitsOfNumber[j] = digit;
            //Если да - учитываем что число добавлено
            j++;
            }
    }
//выводим массив
    Console.Write("[");

    for (int i = 0; i < lenght; i++)
    {
        Console.Write(" " + digitsOfNumber[i]);
    }
        Console.Write("]");


