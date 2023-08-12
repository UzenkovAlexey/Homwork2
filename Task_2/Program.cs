/*
   Задача 2:
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите кoординатной точки Xa");
int coordXA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кoординатной точки Ya");
int coordYA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кoординатной точки Za");
int coordZA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кoординатной точки Xb");
int coordXB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кoординатной точки Yb");
int coordYB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кoординатной точки Zb");
int coordZB = int.Parse(Console.ReadLine());


double coodAB = Math.Sqrt(Math.Pow(coordXB - coordXA , 2) + Math.Pow(coordYB - coordYA, 2) + Math.Pow(coordZB - coordZA, 2));

System.Console.WriteLine($"Растояние {coodAB}");