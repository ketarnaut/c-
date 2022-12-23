/* Программа запрашивает натуральное число M
пользователь вводит с клавиатуры М
Посчититать сколько чисел больше 00 ввел пользователь
*/

//Запросить сколько чисел будет вводить пользователь (M)
Console.WriteLine("введите, сколько чисел будет вводить пользователь");
int M = Convert.ToInt32(Console.ReadLine());

if (M < 0)
{
    Console.WriteLine("Число должно быть больше 0");
    return;
}

int i = 0;
for (int count = 0; count < M; count++)
{
    Console.WriteLine("введите число с клавиатуры");
    if (Convert.ToInt32(Console.ReadLine()) > 0)
    {
        i++;
    }
}

Console.WriteLine(i);
