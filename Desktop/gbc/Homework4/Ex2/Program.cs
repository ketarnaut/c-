/*
Задача 2
Напишите программу, которая принимает на вход число и выдает сумму цифр в числе, которые вляются делителем этого числа
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

//Сгенерировать рандомное число
int digit = new Random().Next(100, 9999999);
Console.Write(digit + " -> ");

//Console.WriteLine("Введите натуральное число");
//int digit = Convert.ToInt32(Console.ReadLine());
int digit2 = digit;
//? по задаче: чтобы шага "Заполнение массива числами" не затиралось первоначальное число, я сразу его добавила в 2 переменные. Думаю, что есть более элегантное и верное решение. Можете подсказать?


//Посчитать длину массива (функция) и поместить в новую переменную   
int lenght = GetSize(digit);

//Создать пустой массив
int [] digitsOfNumber = new int[lenght];

//Заполнить массив числами
for (int i = 0; i < lenght; i++)
{
    digitsOfNumber[i] = digit % 10;
    digit = digit / 10;
}

//Посчитать сумму цифр, подходящих условию (являются делителями)
int sum = 0;
for (int i = 0; i < lenght; i++)
{
    if (digitsOfNumber[i] != 0 && digit2 % digitsOfNumber[i] == 0)
    {
        sum = sum + digitsOfNumber[i];
    }
}

//Вывести сумму 
Console.WriteLine(sum);