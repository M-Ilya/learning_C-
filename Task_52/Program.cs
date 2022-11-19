// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Задаём двумерный массив
System.Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());

//выводим результат в виде строки из массива чисел 
System.Console.WriteLine(string.Join("\t", ArithmeticMean(ShowArray(row, col))));

//метод создания, заполнения и вывода двумерного массива
int[,] ShowArray(int arrRow, int arrCol)
{
    int[,] array = new int[arrRow, arrCol];
    for (int i = 0; i < arrRow; i++)
    {
        for (int j = 0; j < arrCol; j++)
        {
            array[i, j] = new Random().Next(50);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}    

//метод вычисляет среднее арифметическое столбцов
double[] ArithmeticMean(int[,] array)
{
    System.Console.WriteLine();
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sumCol = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumCol += array[j, i];
        }
        result[i] = Math.Round((double) sumCol / array.GetLength(0), 1);
    }
    return result;
}