// Задача 64: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

//Выводим числа в консоль
System.Console.WriteLine(PrintNumber(n));

//Метод, выводящий числа с помощью рекурсии
string PrintNumber(int start)
{
    if (start <= 0)
    {
        return "Введите корректное число"; 
    }
    if(start == 1)
    {
        //return start.ToString();
        return Convert.ToString(start);
    }
    return (start + ", " + PrintNumber(start - 1));
}