// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Пример
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//Ввод чисел
Console.WriteLine("Введите число 1 ");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int number_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3 ");
int number_C = Convert.ToInt32(Console.ReadLine());

//Сравнение чисел.....
int max = number_A;
if(number_B > max)
{
    max = number_B;
}
if(number_C > max)
{
    max = number_C;
}

//Вывод результата
Console.WriteLine($"max = {max}");