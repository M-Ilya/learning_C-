// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//вызываем функцию и выводим результат в консоль
System.Console.WriteLine("Сумма цифр в числе = " + Summ(number));

//функция определения суммы цифр в числе
int Summ(int x)
{
    int result = 0;
    while(x > 0)
    {
        result += x % 10;
        x /= 10;
    }
    return result;
}
