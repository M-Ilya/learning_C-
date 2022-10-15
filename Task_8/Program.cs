//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Пример
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//Ввод чисел
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Вывод чётных чисел.....
int number_temp = 1;
Console.Write($"{number} -> ");
while(number_temp <= number)
{
    if(number_temp % 2 == 0)
    {
        Console.Write($"{number_temp}, ");
    }
    number_temp++;
}