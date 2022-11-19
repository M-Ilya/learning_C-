// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Задаём пеозицию элемента в двумерном массиве
System.Console.WriteLine("Введите строку элемента: ");
int row = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите столбец элемента: ");
int col = int.Parse(Console.ReadLine());

//создаём двумерный массив случайных чисел  
int[,] newArray = CreateArray();

//выводим результат поиска элемента
System.Console.WriteLine($"Элемент {row} строки и {col} столбца: {newArray[row - 1, col - 1]}");

//метод создания и вывода массива
int[,] CreateArray()
{
    int arrRow = 5;
    int arrCol = 5;
    int[,] array = new int[arrCol, arrCol];
    for (int i = 0; i < arrRow; i++)
    {
        for (int j = 0; j < arrCol; j++)
        {
            array[i, j] = new Random().Next(50) ;
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}    

