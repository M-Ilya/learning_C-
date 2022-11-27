// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//Вводим числа
System.Console.WriteLine("Введите положительное число M: ");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите положительное число N: ");
int n = int.Parse(Console.ReadLine());

//Выводим результат в консоль
System.Console.WriteLine("m = " + m + ", n = " + n + " -> A(m, n) = " + AkkermanNumber(m, n));

//Метод, вычисляющий числа по функуции Аккермана с помощью рекурсии
int AkkermanNumber(int start, int end)
{
    if (start < 0 || end < 0)
    {
        System.Console.WriteLine("Введите корректные числа");
        return 0;
    }
    if (start == 0)
    {
        return end + 1;
    }
    else
    {
        if (start != 0 && end == 0)
        {
            return AkkermanNumber(start - 1, 1);
        }
        else
        {
            return AkkermanNumber(start - 1, AkkermanNumber(start, end - 1));
        }
    }
}
