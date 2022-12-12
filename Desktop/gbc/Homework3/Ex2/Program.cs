/*Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void CalcDistance(double xa, double ya, double za, double xb, double yb, double zb, double result)
{
    result = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya) + ((zb - za) * (zb - za)))) ;
    Console.WriteLine(result);
  
}

Console.WriteLine("Введите первую координату 1-ой точки");
double xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату 1-ой точки");
double ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью координату 1-ой точки");
double za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату 2-ой точки");
double xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координату 2-ой точки");
double yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью координату 2-ой точки");
double zb = Convert.ToInt32(Console.ReadLine());

double result = 0;

CalcDistance(xa, ya, za, xb, yb, zb, result);