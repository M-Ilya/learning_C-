// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Вводим значения параметров
System.Console.WriteLine("Введите параметр b1: ");
double b1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите параметр k1: ");
double k1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите параметр b2: ");
double b2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите параметр k2: ");
double k2 = int.Parse(Console.ReadLine());

//вычислем координаты точки пересечения с округлением
double x = Math.Round((b2 - b1)/(k1 - k2), 2);
double y = Math.Round(k1 * x + b1, 2);

Console.WriteLine($"Точка пересечения прямых в координатах X: {x}, Y: {y}");