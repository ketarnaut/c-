//Программа принимает на вход 2 часла и сообщает, является ли 2-ое число кратным первому

Console.WriteLine("Введите число 1");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int secondDigit = Convert.ToInt32(Console.ReadLine());
if (firstDigit % secondDigit == 0 )
{
    Console.WriteLine("Число 2 кратно числу 1");
}

else 
{
    Console.WriteLine("Число 2 не кратно числу 1");
}
