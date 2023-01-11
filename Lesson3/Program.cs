/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
14212 -> нет
12821 -> да
23432 -> да

try
{
Console.Write("Введите целое пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
 
for (int i = 4; i >= 0 ; i--)
{   
    array[i] = a % 10;
    a = (a - array[i]) / 10;
}
 
if ((array[0] == array[4]) & (array [1] == array[3])) Console.WriteLine("Число является полиндромом");
    else Console.WriteLine("Число не является полиндромом.");
}
 
catch
{
    Console.WriteLine("Хватит баловаться.");
}
*/
 
/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 
Console.Write("ВВедите координату x первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату y первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату z первой точки ");
int z1 = Convert.ToInt32(Console.ReadLine());
 
Console.Write("ВВедите координату x второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату y второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите координату z второй точки ");
int z2 = Convert.ToInt32(Console.ReadLine());
 
double len ( int x1, int y1, int z1, int x2, int y2, int z2)
{
    double m = Math.Sqrt(((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)));
    return m;
}
 
Console.WriteLine (len (x1,y1,z1,x2,y2,z2));
 
*/
 
/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
 
for (int i = 1; i <= num; i++) Console.Write(i*i*i + " ");
*/
 
/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
 
Console.Write("Введите размерность пространства: ");
int n = Convert.ToInt32(Console.ReadLine());
 
int[] ar1 = new int[n]; // инициируем массивы
int[] ar2 = new int[n];
 
for (int i = 0; i < n; i++) //вводим координаты в первый массив
{
    Console.Write($" Введите {i+1} координату ПЕРВОЙ точки: ");
    ar1[i] = Convert.ToInt32(Console.ReadLine());
    
}
 
for (int i = 0; i < n; i++) //вводим координаты во второй массив
{
    Console.Write($" Введите {i+1} координату ВТОРОЙ точки: ");
    ar2[i] = Convert.ToInt32(Console.ReadLine());
 
}
int sumsqr = 0;
 
for (int i = 0; i<n; i++) sumsqr = sumsqr+((ar1[i]-ar2[i])*(ar1[i]-ar2[i])); // считам сумму всех квадратов
 
Console.Write("Растояние между точек равно: " + Math.Sqrt(sumsqr)); // выводим корень суммы всех квадратов
 
*/
 
/*Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.*/
 
Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());
 
long j = num;   // определяем количество цифр в числе
int kolsymb = 0;
while (j >= 1)
{
    j = j / 10;
    kolsymb++;
}
 
long[] ar = new long[kolsymb]; // инициализируем массив
 
for (int i = kolsymb - 1; i >= 0; i--) // присваиваем значения каждому индексу массива
{
    ar[i] = num % 10;
    num = (num - ar[i]) / 10;
}

for (int i = 0; i <= kolsymb/2; i++) // проверка на равенство цифр в массиве
{
    if (ar[i] == ar[kolsymb-i-1]) continue;
 
    else 
    { 
    Console.Write("Число не является палиндромом");
    goto link1; 
    }    
}
 
Console.Write("Число является палиндромом");
link1:;
 
//Пришлось использовать оператор GOTO и Continue.

