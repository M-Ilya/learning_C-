// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//Вводим число
Console.WriteLine("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Определяем вторую цифру и выводим её в консоль
Console.WriteLine("Вторая цифра числа: " + (number % 100 / 10));