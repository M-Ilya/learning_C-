// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Метод, заполняющий массив
int[] Array()
{
    int[] arrayNumber = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arrayNumber[i] = new Random().Next(0, 100);
    } 
    return arrayNumber;
}

//Метод, выводящий на экран
void printArray(int[] arrPrint)
{
    System.Console.WriteLine(string.Join(", ", arrPrint));
}

//запускаем метод, который вызывает метод
printArray(Array());