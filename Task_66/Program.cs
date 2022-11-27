// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

//Выводим результат в консоль
System.Console.WriteLine("M = " + m + "; N = " + n + " -> " + GetNumber(m, n));

//Метод, выводящий числа с помощью рекурсии
int GetNumber(int start, int end)
{
    if (start > end)
    {
        System.Console.WriteLine("Введите корректные числа");
        return 0;
    }
    if(start == end)
    {
        return start;
    }
    return start + GetNumber(start + 1, end);
}