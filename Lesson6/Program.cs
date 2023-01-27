/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


void FillArray(int[] array, int len)
{
    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void Positive(int[] array, int len)
{
    int kolposit = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > 0) kolposit++;
    }
    Console.WriteLine("Количество положительных элементов: " + kolposit);
}

void PrintArray(int[] array, int len)
{
    for (int i = 0; i < len; i++) Console.Write(array[i] + " ");
}

Console.Write("Введите количство элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

FillArray(array, len);
PrintArray(array, len);
Console.WriteLine();
Positive(array, len);

*/



/*

Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5


Console.Write($"Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void CrossPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 & b1 != b2) Console.Write("Прямые параллельны."); // проверяем на параллельность
    else if (k1 == k2 & b1 == b2) Console.Write("Прямые совпадают."); // проверка на совпадение
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.Write($"Точка пересечениядвух прямых: ({x}; {y})");
    }


}

CrossPoint(b1, k1, b2, k2);
*/

/*
задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
является ли он прямоугольным, равнобедренным, равносторонним.

Console.Write($"Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите третье число: ");
int x3 = Convert.ToInt32(Console.ReadLine());

void Triangle(double x1, double x2, double x3)
{
    if ((x1 + x2 <= x3) || (x1 + x3 <= x2) || (x2 + x3 <= x1)) 
    {
        Console.WriteLine("Данные не являются сторонами треугольника"); return;
    }
    else if ((x1 == x2) & (x2 == x3)) Console.WriteLine("Треугольник является равносторонним");
    else if ((x1 == x2) || (x2 == x3) || (x1 == x3)) Console.WriteLine("Треугольник является равнобедренным");
    else if ((x1*x1)+(x2*x2) == x3*x3 || (x1*x1)+(x3*x3) == x2*x2 || (x2*x2)+(x3*x3) == x1*x1) Console.WriteLine("Треугольник является прямоугольным");
    
    double p = (x1+x2+x3)/2;
    double sq = Math.Sqrt(Math.Abs((p*(p-x1)*(p-x2*(p-x3)))));
    Console.WriteLine("Площадь равна: " + sq);
    
    Console.WriteLine("Периметр равен: " + (p*2));

    double ag1 = (Math.Acos(Math.Abs(x1*x1+x2*x2-x3*x3)/(2*x1*x2)))/Math.PI*180;
    double ag2 = (Math.Acos(Math.Abs(x1*x1+x3*x3-x2*x2)/(2*x1*x3)))/Math.PI*180;
    double ag3 = (Math.Acos(Math.Abs(x3*x3+x2*x2-x1*x1)/(2*x3*x2)))/Math.PI*180;
    
    Console.WriteLine($"Угол между сторонами равными {x1} и {x2} равен {ag1}");
    Console.WriteLine($"Угол между сторонами равными {x1} и {x3} равен {ag2}");
    Console.WriteLine($"Угол между сторонами равными {x2} и {x3} равен {ag3}");
}
Triangle(x1, x2, x3);

*/

/*
задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.



Console.Write($"Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MaxNum(int[,] array)
{
    int max = array[0, 0];       //! ищем максимальное значение
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max) max = array[i, j];
        }

    }
    Console.WriteLine("Максимальное значение: " + max);
    Console.WriteLine();

    Console.WriteLine("Индексы максимальных значений: ");
    for (int i = 0; i < array.GetLength(0); i++) //! ищем индексы всех максимумов
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == max)
                Console.WriteLine($"({i}),({j})");
        }
    }

}

void MinNum(int[,] array)
{
    int min = array[0, 0];       //! ищем минимальное значение
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) min = array[i, j];
        }

    }
    Console.WriteLine("Минимаьное значение: " + min);
    Console.WriteLine();

    Console.WriteLine("Индексы минимальных значений: ");
    for (int i = 0; i < array.GetLength(0); i++) //! ищем индексы всех минимумов
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == min)
                Console.WriteLine($"({i}),({j})");
        }
    }

}

FillArray(array);
Console.WriteLine();
MaxNum(array);
Console.WriteLine();
MinNum(array);
Console.WriteLine();

*/

/* Задача 6sem VERY HARD необязательная Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. Порядок элементов менять нельзя.
Одно число - это не последовательность.
Пример:
[1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
[1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
[1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]
*/

// Console.Write($"Введите размерность массива: ");
// int arraylength = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[arraylength];

// FillArray(array);
// Console.WriteLine();
// FindSequence(array);

// void FillArray(int[] array)
// {
//     Console.Write("Сгенерированный массив: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//         Console.Write(array[i] + " ");
//     }
// }

// void FindSequence(int[] array)
// {
//     bool[] arraynum = new bool[10];
//     for (int i = 0; i < array.Length; i++) arraynum[array[i]] = true;

//     for (int j = 0; j < arraynum.Length; j++) Console.Write(arraynum[j] + " ");

//     int maxnum = 0; int count = 0; int number = 0;

//     for (int j = 0; j < arraynum.Length - 1; j++)
//     {

//         if (arraynum[j] == true & arraynum[j + 1] == true) { count++; maxnum = count; }
//         else if (maxnum < count) { count = 0; number = j; }

//     }
//     Console.WriteLine();
//     Console.WriteLine(maxnum + 1);
//     Console.WriteLine(number);
// }


