/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100,1000);
        Console.Write(array[i] + " ");
    }
    }

void EvensArray(int [] array)
{
    int evens = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) evens++;
    } 
    Console.Write($"В массиве {evens} четных чисел.");
}


Console.Write("Введите количество элеметнов массива: ");
int len = Convert.ToInt32 (Console.ReadLine());

int [] array = new int [len];

FillArray(array);
Console.WriteLine();
EvensArray(array);

*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
}

void OddSum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    } 
    Console.Write($"Сумма нечетных цисел массива равна: {sum}");
}


Console.Write("Введите количество элеметнов массива: ");
int len = Convert.ToInt32 (Console.ReadLine());

int [] array = new int [len];

FillArray(array);
Console.WriteLine();
OddSum(array);

*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array) //! заполняем массив вещественными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100) + new Random().NextDouble();
        Console.Write($"({array[i]})");
    }
}

void MaxArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++) //! Ищем максимум
    {
        if (max < array[i]) max = array[i];
    }
    Console.WriteLine("Максимальный элемент: " + max);
    
    for (int i = 0; i < array.Length; i++) //! Ищем минимум
    {
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine("Минимальный элемент: " + min);

    Console.Write("Разница между минимальным и максимальным элементом: " + (max - min));

}

Console.Write("Введите количество элеметнов массива: ");
int len = Convert.ToInt32(Console.ReadLine());

double[] array = new double[len];

FillArray(array);
Console.WriteLine();
MaxArray(array);
*/


/*Задача 30: - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
Далее заполняет его случайными уникальными числами и выводит на экран. Далее производим сортировку массива от большего к меньшему и выводим на экран. 
Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 
Встроенные методы работы со списками использовать нельзя.
*/


void FillArray(int[] array, int maxnumber, int minnumber) //! заполняем массив уникальными числами
{

    for (int i = 0; i < array.Length; i++)
    {

    link1:
        array[i] = new Random().Next(minnumber, maxnumber + 1);
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    goto link1;
                }
            }
        }
    }
}


void PrintArray(int[] array) //! Вывод массива на экран
{
    //Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"({array[i]}) ");
    Console.WriteLine();
}

void Sortarray(int[] array, int len) //! сортировка массива от большего к меньшему
{
    for (int i = 0; i < len - 1; i++)
    {
        int m = 0;
        for (int j = 0; j + i < len - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                m = array[j];
                array[j] = array[j + 1];
                array[j + 1] = m;
            }
        }

    }
}

void RandomArray(int[] array, int len) //! берем два случайных индекса и меняем элементы местами, и так 50 раз
{
    for (int i = 0; i < 50; i++)
    {
        int m = 0;
        int random1 = new Random().Next(0,len);
        int random2 = new Random().Next(0,len);

        m = array[random1];
        array[random1] = array[random2];
        array[random2] = m;
    }
}

link2:

Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное возможное число: ");
int minnumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное возможное число: ");
int maxnumber = Convert.ToInt32(Console.ReadLine());

if (maxnumber - minnumber < len - 1) //! Проверка на размер массива и кол-во уникальных значений
{
    Console.WriteLine("Данные некорректны, размер массива превышает количество уникальных значений");
    goto link2;
}

int[] array = new int[len];

FillArray(array, maxnumber, minnumber);
Console.Write("Массив: ");
PrintArray(array);
Sortarray(array, len);
Console.Write("Отсортированный массив: ");
PrintArray(array);
RandomArray(array, len);
Console.Write("Рандомный массив: ");
PrintArray(array);

Console.ReadKey();
