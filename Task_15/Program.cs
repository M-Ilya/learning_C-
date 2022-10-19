// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Вводим число
Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

//Проверяем, равно ли число 6 или 7
if(number > 0 && number < 8)
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной день  -  ДА ");
    }
    else Console.WriteLine("Это рабочий день  -  НЕТ ");
}
else Console.WriteLine("Это не день недели  -  ОШИБКА ");