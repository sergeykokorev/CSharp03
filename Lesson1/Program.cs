
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2) Console.WriteLine("Числав равны между собой.");
      
    else if (number1 > number2)
        {
            Console.WriteLine($"Число {number1} больше числа {number2}");
        }
        else
        {
            Console.WriteLine($"Число {number1} меньше числа {number2}");
        }
*/





/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2) max = number2;
if (max < number3) max = number3;
    
Console.WriteLine("Максимальное число число: " + max);
*/


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет 


Console.WriteLine("Ведите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0) Console.WriteLine($"Число {number1} является четным");
    else Console.WriteLine($"Число {number1} является нечетным");

*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.WriteLine("Ведите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count<number1)
    {
        Console.Write(count + " ");
        count += 2;
    }

*/