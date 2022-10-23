// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
//Вводим координаты точки А
Console.WriteLine("Введите координату Х точки А ");
int numAX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А ");
int numAY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А ");
int numAZ = int.Parse(Console.ReadLine());

//Вводим координаты точки B
Console.WriteLine("Введите координату Х точки B ");
int numBX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B ");
int numBY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B ");
int numBZ = int.Parse(Console.ReadLine());

//Вычисляем расстояние между точками
double length_AB = Math.Sqrt(Math.Pow((numBX - numAX), 2) + Math.Pow((numBY - numAY), 2) + Math.Pow((numBZ - numAZ), 2));
Console.WriteLine("Расстояние между точками А и В -  " + "{0 : 0.00}", length_AB);