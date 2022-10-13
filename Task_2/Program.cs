// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Пример
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//Ввод чисел
Console.WriteLine("Введите число 1 ");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int number_B = Convert.ToInt32(Console.ReadLine());

//Сравнение чисел.....
if(number_A > number_B)
{
    Console.WriteLine($"max = {number_A}");
    Console.WriteLine($"min = {number_B}");
}
else
{
    Console.WriteLine($"max = {number_B}");
    Console.WriteLine($"min = {number_A}");
}