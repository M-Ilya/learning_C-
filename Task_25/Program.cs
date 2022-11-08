// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число, возводимое с степень: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите степень числа: ");
int exponent = int.Parse(Console.ReadLine());

//вызываем функцию
System.Console.WriteLine(number + " в степени " + exponent + " = " + Expon(number, exponent));

//Функция возведения в степень
int Expon(int a, int x)
{
    int result = 1;
    for (int i = 0; i < x; i++)
    {
        result *= a;
    }
    return result;
}