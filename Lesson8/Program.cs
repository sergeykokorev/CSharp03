// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, cols];

// FillArray(array);
// Console.WriteLine();
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);


// void FillArray(int[,] array)                                                             //Задаем массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 99);
// }

// void PrintArray(int[,] array)                                                           // выводим на экран                                                              
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)                                                            // Сортировка
// {
//     Console.WriteLine("Отсортированный массив:");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1) - 1; k++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//                 if (array[i, j] < array[i, j + 1])
//                 {
//                     (array[i, j], array[i, j + 1]) = (array[i, j + 1], array[i, j]);
//                 }
//         }
//     }
// }


// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите размерность прямоугольного массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());


// int[,] array = new int[rows, rows];

// FillArray(array);
// Console.WriteLine();
// PrintArray(array);
// SortArray (array);

// void FillArray(int[,] array)                                                             //Задаем массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)                                                           // выводим на экран                                                              
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],3} \t");
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)                                                            // Поиск минимального числа и строки
// {
//     int xPos = 0; int min = array[0, 0];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i,j]; xPos = i;
//             }
//         }
//     }
//     Console.WriteLine($"Минимальный элемент находится на {xPos+1} строке");
// }




// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// Console.Write("Введите количество строк первой матрицы: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первой матрицы: ");
// int cols1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк второй матрицы: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второй матрицы: ");
// int cols2 = Convert.ToInt32(Console.ReadLine());

// if (cols1 != rows2) {Console.WriteLine("Матрицы с данными параметрами перемножить невозможно."); return; }

// int[,] array1 = new int[rows1, cols1];
// int[,] array2 = new int[rows2, cols2];
// int[,] arrayResult = new int[rows1, cols2];

// FillArray(array1);
// FillArray(array2);
// PrintArray(array1);
// Console.WriteLine();
// PrintArray(array2);
// Console.WriteLine();
// ArrayResult(arrayResult);
// Console.WriteLine("Результат: ");
// Console.WriteLine();
// PrintArray(arrayResult);

// void FillArray(int[,] array1)                                                             //Задаем массив
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//         for (int j = 0; j < array1.GetLength(1); j++)
//             array1[i, j] = new Random().Next(1, 5);
// }

// void PrintArray(int[,] array1)                                                           // выводим на экран массив                                                          
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//             Console.Write($"{array1[i, j],2} \t");
//         Console.WriteLine();
//     }
// }

// void ArrayResult (int [,] arrayResult)                                                  // вычисляем произведение 
// {
//     for (int i = 0; i < arrayResult.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayResult.GetLength(1); j++)
//                 for (int k = 0; k < array2.GetLength(0); k++)
//                     arrayResult[i,j] = arrayResult[i,j] + (array1 [i,k] * array2 [k,j]);

//     }
// }


// // Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)


// Console.Write("Введите значение по оси Х ");
// int sizeX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение по оси Y ");
// int sizeY = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение по оси Z ");
// int sizeZ = Convert.ToInt32(Console.ReadLine());

// if (sizeX * sizeY * sizeZ > 91)                                                            // двузначных числел 90 шт
// {
//     Console.WriteLine("Данный массив невозможно заполнить уникальными двузначными числами, попробуйте уменьшить размерность массива");
//     return;
// }

// int[,,] array = new int[sizeX, sizeY, sizeZ];
// bool[] boolarray = new bool[100];                                                       // здесь задаем одномерный булевый массив, будут использоваться только индексы от 10 и до 99

// FillArray(array);
// PrintArray(array);


// void FillArray(int[,,] array)                                                             //Задаем массив
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(2); k++)
//             {

//             link1:
//                 array[i, j, k] = new Random().Next(10, 100);
//                 if (boolarray[array[i, j, k]] != false) goto link1;

//                 boolarray[array[i, j, k]] = true;

//             }
// }


// void PrintArray(int[,,] array1)                                                           // выводим на экран массив                                                          
// {
//     for (int i = 0; i < array1.GetLength(0); i++)
//         for (int j = 0; j < array1.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(2); k++)

//                 Console.WriteLine($"{array[i, j, k]}: ({i}),({j}),({k}) ");
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




Console.Write("Введите размерность массива ");
int sizearray = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[4, 4];

SpiralArray(array);
PrintArray(array);

void SpiralArray(int[,] array)
{
    int sum = 0;
    int m=1;
    int d = 1;
    for (int z = 0; z < 2; z++)
    {
        
        {
            int i = z; int j = z;
        while (j < m)
        {
            sum++; array[i+d, j+d] = sum; j++;
        }

        i = z; j = z;
        while (j < m)
        {
            sum++; array[j+d, m - i+d] = sum; j++;
        }

        i = z; j = z;
        while (j < m)
        {
            sum++; array[m - i+d, m - j+d] = sum; j++;
        }

        i = z; j = z;
        while (i < m)
        {
            sum++; array[m - i+d, j+d] = sum; i++;
        }
        }    
        
    }

} 





void PrintArray(int[,] array)                                                           // выводим на экран массив                                                          
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} \t");
        Console.WriteLine();
    }
}