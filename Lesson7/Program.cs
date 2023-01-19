
// Задача HARD SORT необязательная. Считается за три обязательных** 
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] array = new int[rows, cols];
// int[] array1 = new int[rows*cols];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// NewArray(array1);
// SortArray(array1);
// NewSortArray(array1);
// PrintArray(array);

// void FillArray(int[,] array)                                    //Задаем массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(10, 99);
// }

// void PrintArray(int[,] array)                                   //Печатаем массив
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }

// void NewArray(int[] array1)                                     //создаем одномерынй массив
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array1[count] = array[i, j];count++;
//             //Console.Write(array1[count-1] + " ");

//         }

// }

// void SortArray(int[] array1)                                    // сортировка массива
// {
//     int max = array1[0];
//     for (int i = 0; i < array1.Length; i++)
//     {

//         for (int j = 0; j < array1.Length - 1; j++)
//         {
//             if (array1[j] > array1[j + 1])
//             {
//                 max = array1[j];
//                 array1[j] = array1[j + 1];
//                 array1[j + 1] = max;
//             }
//         }

//     }
// }

// void NewSortArray (int [] array1)                               // Присваиваем значения одномерного массива двумерному
// {
// Console.WriteLine("Новый массив: ");
//     Console.WriteLine();
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = array1[count]; count++;

//         }

// }





/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
double[,] array = new double[rows, cols];

RandomArray(array);
PrintArray(array);

void RandomArray (double[,] array)                                                                                                      // генерируем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round((Convert.ToDouble(new Random().Next(10, 99)))/(Convert.ToDouble(new Random().Next(10, 20))),3);    // такой вот способ рандомизации
            
}

void PrintArray(double[,] array)                                                                                                        //Печатаем массив
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],6} \t");
        Console.WriteLine();
    }
}

*/



/*
Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Console.WriteLine();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
SearchNumber(array);


void FillArray(int[,] array)                                    //Задаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(10, 99);
}

void PrintArray(int[,] array)                                       // выводим на экран                                                              
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],6} \t");
        Console.WriteLine();
    }
}

void SearchNumber (int [,] array)                                       // Ищем элемент в массиве
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i,j] == searchNumber) 
            {
                Console.WriteLine ($"Искомое число {searchNumber} находится на позиции ({i},{j})");
                return;
            }
    Console.WriteLine ("Иcкомый элемент не найден");

}

*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
double t = 0;

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
AvarageNumber(t);

void FillArray(int[,] array)                                    //Задаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)                                       // выводим на экран                                                              
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

void AvarageNumber(double t)
{
    double sumnumber;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumnumber = 0;
        for (int j = 0; j < array.GetLength(0); j++) sumnumber = sumnumber + array[j, i];

        double avrnum = Math.Round(Convert.ToDouble(sumnumber / array.GetLength(0)), 2);
        Console.Write($"({avrnum})");
    }
}


*/

// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. 
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
// причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

Console.WriteLine();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

if ((rows * cols) % 2 == 1)
{
    Console.WriteLine("Количество элементов должно быть четным");
    return;
}

int[,] array = new int[rows, cols];
bool[,] boolarray = new bool[rows, cols];

FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);


void FillArray(int[,] array)                                                             //Задаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 99);
}

void PrintArray(int[,] array)                                                           // выводим на экран                                                              
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{

    for (int i = 0; i < (array.GetLength(0) * array.GetLength(1)) / 2; i++)             // количество итераций   (array.GetLength(0) * array.GetLength(1)) / 2
    {
        link1:
        int x1 = new Random().Next(0, array.GetLength(0));                              // задаем случайные координаты двух элементов
        int y1 = new Random().Next(0, array.GetLength(1));
        int x2 = new Random().Next(0, array.GetLength(0));
        int y2 = new Random().Next(0, array.GetLength(1));

        if (boolarray[x1, y1] != false | boolarray[x2, y2] != false) goto link1;        // если не выполняются эти условия, то задаются новые случайные координаты
        if ((x1==x2)&(y1==y2)) goto link1;
        
        (array[x1, y1], array[x2, y2]) = (array[x2, y2], array[x1, y1]);                // замена значений 
        boolarray[x1, y1] = true; boolarray[x2, y2] = true;                             // В булевом массиве проставляем тру в уже замененных элементах
    }

}