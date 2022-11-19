// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Задаём двумерный массив
System.Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());

//запускаем метод, который заполняет и выводит массив в консоль 
ShowArray(row, col);

//метод 
void ShowArray(int arrRow, int arrCol)
{
    double[,] array = new double[arrCol, arrCol];
    for (int i = 0; i < arrRow; i++)
    {
        for (int j = 0; j < arrCol; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 100 - new Random().NextDouble() * 100, 1);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}    