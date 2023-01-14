/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16



Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень числа: ");
int step = Convert.ToInt32(Console.ReadLine());

try
{
    int Step(int num, int step) // Ввод функции
    {
        int n = 1;
        for (int i = 1; i <= step; i++) n = n * num;
        return n;
    }

    Console.Write($"Число {num} в степени {step} равно = {Step(num, step)}");
}

catch
{
    Console.Write("Соберитесь.");
}

*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
452 -> 11
82 -> 10
9012 -> 12 

// ! Вводим функцию
void Count(int num)
{
    int sum = 0;
    while (((num % 10) > 0) || (num>0))
        {
        sum = (sum + num % 10);
        num = (num - (num%10))/10;
        }
        Console.Write($"Сумма цифр равна: {sum}");
}

// ! тело программы
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Count(num);
*/


/* Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.



void FillArray(int [] array) 
{ 
    for (int i=0;i<array.Length; i++) 
    {
        Console.Write($"Введите число №{i+1}:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

}

void PrintArray (int [] array)
{
    {
    for (int i=0;i<array.Length; i++) Console.Write($"{(array[i])} ");
    }
} 

int [] array = new int[8];
FillArray(array);
PrintArray(array);
*/


/* Задачу сам придумал, Напишите программу, которая принимает на вход целое или дробное число и выдаёт сумму цифр.
// ! Преобразуем число в натуральное 1,56 => 156

int Nat(double num)
{
    //double newNum = num;
    while (num != Convert.ToInt32(num)) num = num*10;
    return Convert.ToInt32(num);
}


// ! Вводим функцию

void Count(int s)
{
    int sum = 0;
    while (((s % 10) > 0) || (s>0))
        {
        sum = (sum + s % 10);
        s = (s - (s%10))/10;
        }
        Console.Write($"Сумма цифр равна: {sum}");
}

// ! тело программы

Console.Write("Введите натуральное число: ");
double num = Convert.ToDouble(Console.ReadLine());
int s = Nat(num);
Count(s);

*/

/*Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
452 -> 3
82 -> 2
9,012 ->4



// ! Преобразуем число в натуральное 1,56 => 156

int Nat(double num)
{
    //double newNum = num;
    while (num != Convert.ToInt64(num)) num = num * 10;
    int m = Convert.ToInt32(num);
    return m;
}


// ! Вычисляем кол-во цифр

void Count(int s)
{
    int j = 0;
    for (int i = 0; s > 0; i++) 
    {
    s = s/10;
    j++;
    }
     Console.Write($"Количество цифр: {j}");}

// ! тело программы

Console.Write("Введите натуральное число: ");
double num = Convert.ToDouble(Console.ReadLine());
int s = Nat(num);
Count(s);

*/

/*Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
*/

/*
void FillArray(int[] array) //! Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

void PrintArray(int[] array) //! Вывод массива на экран
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"({array[i]}) ");
    Console.WriteLine();
}

int MaxNumArray(int[] array) //! Считаем максимальное число 
{
    int maxnum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxnum) maxnum = array[i];
    }
    return maxnum;
}

int MaxIndArray(int[] array) //! Считаем индекс максимального числа
{
    int maxnum = array[0];
    int j = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxnum)
        {
            maxnum = array[i];
            j = i;
        }
    }
    return j;
}

int MinNumArray(int[] array) //! Считаем минимальное число 
{
    int minnum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minnum) minnum = array[i];
    }
    return minnum;
}

int MinIndArray(int[] array) //! Считаем индекс минимального числа
{
    int minnum = array[0];
    int j = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minnum)
        {
            minnum = array[i];
            j = i;
        }
    }
    return j;
}


double SrAr(int[] array) //! Ищем среднее арифметическое значение
{
    int srsum = 0;
    for (int i = 0; i < array.Length; i++) srsum = srsum + array[i];
    double srar = Convert.ToDouble(srsum) / Convert.ToDouble(array.Length);
    return srar;
}

void PrintArraySvod(double[] svodarray) //! Вывод сводного массива на экран
{
    Console.Write("Сводный массив: ");
    for (int i = 0; i < svodarray.Length; i++)
        Console.Write($"({svodarray[i]})");
    Console.WriteLine();
}
void SvodArray(double[] svodarray, int[] array) //! назначаем элементам сводного массива значения и выводим значения сводного массива
{
    svodarray[0] = MaxNumArray(array);
    Console.WriteLine($"Максимальное число массива: {svodarray[0]}");

    svodarray[1] = MaxIndArray(array);
    Console.WriteLine($"Индекс максимального числа массива: {svodarray[1]}");

    svodarray[2] = MinNumArray(array);
    Console.WriteLine($"Миниимальное число массива:{svodarray[2]}");

    svodarray[3] = MinIndArray(array);
    Console.WriteLine($"Индекс минимального числа массива: {svodarray[3]}");

    svodarray[4] = SrAr(array);
    Console.WriteLine($"Среднее арифметическое массива: {svodarray[4]}");
}

void Sortarray(int[] array, int len) //! сортировка массива
{
    for (int i = 0; i < len-1; i++)
    {
        int m = 0;
        for (int j = 0; j + i < len-1; j++)
        {
            if (array[j] > array[j+1]) 
            {
                m = array[j];
                array[j] = array[j+1];
                array[j+1] = m;
            }
        }

    }
}

void PrintArray1(int[] array) //! Вывод отсортированного массива на экран
{
    Console.Write("Отсортированный массив: ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"({array[i]}) ");
    Console.WriteLine();
}

void Med (int[] array, int len)
{
    if (len%2!=0) 
    {
        Console.Write($"Медианное значение: {array[(len-1)/2]}");
    }
        else
        {
            double med = Convert.ToDouble((array[(len/2-1)] + array[(len/2)]))/2;
            Console.Write($"Медианное значение:{med}");
        }
}


//! Основная часть программы
Console.Write("Введите количество элементов массива: "); // ! вводим количество элементов массива
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len]; // ! инициируем массив
double[] svodarray = new double[5]; //! инициируем сводный массив

FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SvodArray(svodarray, array);
Console.WriteLine();
PrintArraySvod(svodarray);
Console.WriteLine();

Sortarray(array,len);
PrintArray1(array);
Med(array,len);


*/
