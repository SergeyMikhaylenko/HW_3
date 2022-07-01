// Задача 21: Напишите программу, которая принимает на
//  вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Convert.ToInt32(Console.ReadLine());

int y1 = Convert.ToInt32(Console.ReadLine());

int x2 = Convert.ToInt32(Console.ReadLine());

int y2 = Convert.ToInt32(Console.ReadLine());

int x3 = Convert.ToInt32(Console.ReadLine());

int y3 = Convert.ToInt32(Console.ReadLine());


double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)+Math.Pow(y3-y3,2)); 

Console.WriteLine(Math.Round(d) );