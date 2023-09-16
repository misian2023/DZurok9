// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// {
//     Console.Write("Введите первое число: ");
//     int a = int.Parse(Console.ReadLine());

//     Console.Write("Введите второе число: ");
//     int b = int.Parse(Console.ReadLine());

//     int max, min;

//     if (a > b)
//     {
//         max = a;
//         min = b;
//     }
//     else
//     {
//         max = b;
//         min = a;
//     }

//     Console.WriteLine($"Максимальное число: {max}");
//     Console.WriteLine($"Минимальное число: {min}");
// }

//         Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//         {
//         Console.WriteLine("Введите три числа:");

//         // Считываем три числа с консоли
//         int number1 = int.Parse(Console.ReadLine());
//         int number2 = int.Parse(Console.ReadLine());
//         int number3 = int.Parse(Console.ReadLine());

//         // Находим максимальное из трех чисел с помощью метода Math.Max
//         int maxNumber = Math.Max(Math.Max(number1, number2), number3);

//         // Выводим максимальное число
//         Console.WriteLine("Максимальное число: " + maxNumber);
//     }

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// {
//     Console.WriteLine("Введите число:");
//     int number = int.Parse(Console.ReadLine());

//     if (number % 2 == 0)
//     {
//         Console.WriteLine("Число является четным.");
//     }
//     else
//     {
//         Console.WriteLine("Число не является четным.");
//     }
// }

//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// {
//     Console.Write("Введите число N: ");
//     if (int.TryParse(Console.ReadLine(), out int n))
//     {
//         Console.WriteLine("Четные числа от 1 до " + n + ":");
//         for (int i = 2; i <= n; i += 2)
//         {
//             Console.Write(i + ",");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
//     }
// }

// Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int num = new Random() .Next(10,100);
// Console.WriteLine(num);
// int num1 = new Random() .Next(10,100);
// Console.WriteLine(num1);
// int num2 = new Random() .Next(10,100);
// Console.WriteLine(num2);

// FindMaxDigit(num);
// FindMaxDigit(num1);
// FindMaxDigit(num2);

// void FindMaxDigit(int number)
// {
// int FirstDigit=number/10;
// int secondDigit=number%10;
// Console.WriteLine($"{FirstDigit}, {secondDigit}");
// if (FirstDigit > secondDigit)
// {
//    Console.WriteLine(FirstDigit);
// }
// else if(FirstDigit == secondDigit)
// {
//    Console.WriteLine("цифры равны");
// }
// else
// {
// Console.WriteLine(secondDigit);
// }
// }


// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта 
// точка

// int WorkWithUser(string message)
// {

//  Console.Write(message);
//  int number = int.Parse(Console.ReadLine());
//  return number;
// }


// string FundQuarter(int X, int Y )
// {
// string result = string.Empty;
// if (X > 0 && Y > 0)
// {
//  result ="I четверть";
// }
// else if(X < 0 && Y > 0)
// {
//   result ="II четверть";
// }
// else if(X < 0 && Y < 0)
// {
//   result ="III четверть";
// }
// else if(X > 0 && Y < 0)
// {
//   result ="IV четверть";
// }
// else
// {
//   result ="Ошибка";
// }
// return result;
// }

// int x = WorkWithUser("Введите точку X : ");
// int y = WorkWithUser("Введите точку Y : ");
// Console.WriteLine(FundQuarter(x,y));

// using System;

// public class Answer
// {
//     static void ShowCube(int N)
//     {
//         for (int i = 1; i <= N; i++)
//         {
//             Console.WriteLine(Cube(i));
//         }
//     }

//     public static int Cube(int number)
//     {
//         return number * number * number;
//     }

//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//             N = 6;
//         }

//         ShowCube(N);
//     }
// }

// Задача с урока 4 "Функции"
// Напишите программу, которая 
// принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int WorkWithUser(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }
// int FindSum(int number)
// {
//     int sum= 0;
//     for (int i = 1; i <= number; i++)
//     {
//        sum += i;
//     }
//     return sum;
// }

// int num = WorkWithUser("Введите число А: ");
// Console.WriteLine(FindSum(num));


// 2 вариант решения это задачи 

// int number = int.Parse(Console.ReadLine());
// return number;
// }
// int FindSum(int number)
// {
// int sum = 0;
// for (int i = 1; i <= number; i++)
// {
// sum += i;
// }
// return sum;
// }

// int num = WorkWithUser("Введите число А: ");
// int summ = FindSum(num);

// int num1 = WorkWithUser("Введите число B: ");
// int summ1 = FindSum(num1);

// int num2 = WorkWithUser("Введите число C: ");
// int summ2 = FindSum(num2);

// Console.WriteLine($"{summ}, {summ1}, {summ2} сумма сумм {summ + summ1 + summ2}");

