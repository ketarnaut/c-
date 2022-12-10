// сгенерировать случайное число от 10 до 99 и выбрать бОльшую цифру из 2-ух

int N = new Random().Next(10, 99);
int firstDigit = N / 10;
int secondDigit = N % 10;

Console.WriteLine(N);

Console.Write("Больше число: ");

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else 
{
    Console.WriteLine(secondDigit);
}

