// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Задаём массив вещественных чисел
double min = 0, max = 0;
System.Console.WriteLine("Введите количество чисел массива: ");
int count = int.Parse(Console.ReadLine());
double[] array = new double[count];

//Заполняем массив случайными числами
for (int i = 0; i < count; i++)
{
    array[i] = new Random().NextDouble() * 100;
    array[i] = Math.Round(array[i], 1);         //округяем до 1-го знака после запятой
}

//Находим максимальный и минимальный элемент массива
min = array[0];
for (int i = 0; i < count; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
    if (max < array[i])
    {
        max = array[i];
    }
}

//Выводим результат
System.Console.WriteLine(string.Join(" : ", array) + " -> " + (max - min));