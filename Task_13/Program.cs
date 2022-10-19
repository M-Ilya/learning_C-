// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Вводим число
Console.WriteLine("Введите любое число: ");
string number = Console.ReadLine();

//По длине строки находим третью цифру
if(number.Length > 2)
{
    int number3 = Convert.ToInt32(number[2].ToString());
    Console.WriteLine("Третья цифра числа: " + number3);
}
else
{
    Console.WriteLine("Третьей цифры нет( ");
}

