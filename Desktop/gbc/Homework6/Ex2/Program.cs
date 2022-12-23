/*
Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.WriteLine("введите значение b1");
float b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение k1");
float k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение b2");
float b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение k2");
float k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны или совпадают"); 
}

else if (k1 * k2 == -1 || k1 == -1/k2)
{
    Console.WriteLine("Прямые перпендикулярны"); 
}

else
{
    //k1 * x + b1 = k2 * x + b2
    //(k1 * x) - (k2 * x) = b2 - b1
    //x * (k1 - k2) = b2 - b1
    //x = (b2 - b1) / (k1 - k2)
    float x = (b2 - b1) / (k1 - k2); //(4 - 2) / (5-9) = 2 / -4 = -0.5
    float y = k1 * x + b1;
    Console.WriteLine("Прямые пересекаются в точке (" + x + ";" + y + ")"); 

}