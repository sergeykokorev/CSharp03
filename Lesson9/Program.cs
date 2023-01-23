// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// Numbers(number);

// void Numbers(int number)
// {
//     if (number == 0) return;
//     Console.Write(number + " ");
//     Numbers(number - 1);
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите минимальное число:");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число:");
int maxNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers());

void Numbers(int maxNumber, int minNumber, int sum)
{
    int sumNumbers = 0;
    if (maxNumber == minNumber) return sumNumbers;
    sumNumbers = sumNumbers + Numbers(maxNumber - 1);
}