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


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


// Console.WriteLine("Введите минимальное число:");
// int maxNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число:");
// int minNumber = Convert.ToInt32(Console.ReadLine());
// int sum = 0;


// Sum (maxNumber, minNumber);

// void Sum (int numberM, int numberN)
// {

//     if (maxNumber > minNumber) 
//     {
//         Console.WriteLine($"Сумма чисел равна: {sum}"); return;
//     }
//     sum = sum + (maxNumber++);
//     Sum(maxNumber, minNumber);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите первое неотрицательное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akerman(number1,number2));

int Akerman(int number1, int number2)
{
    if (number1 == 0) return (number2 + 1);
        else if ((number1 > 0) && (number2 == 0)) return Akerman(number1 - 1, 1);
        else if ((number1 > 0) && (number2 > 0)) return Akerman(number1 - 1, Akerman(number1, number2 - 1));
        else return number2 + 1;
}

