// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число A: ");
//         int A = int.Parse(Console.ReadLine());

//         Console.Write("Введите степень B: ");
//         int B = int.Parse(Console.ReadLine());

//         int result = 1;

//         for (int i = 0; i < B; i++)
//         {
//             result *= A;
//         }

//         Console.WriteLine($"Результат: {result}");
//     }
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число: ");
//         string input = Console.ReadLine();

//         int sum = 0;

//         foreach (char digitChar in input)
//         {
//             if (char.IsDigit(digitChar))
//             {
//                 int digit = int.Parse(digitChar.ToString());
//                 sum += digit;
//             }
//         }

//         Console.WriteLine($"Сумма цифр в числе {input} равна: {sum}");
//     }
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = new int[8]; // Создаем массив из 8 элементов

//         // Заполняем массив числами, например:
//         numbers[0] = 1;
//         numbers[1] = 2;
//         numbers[2] = 5;
//         numbers[3] = 7;
//         numbers[4] = 19;

//         // Выводим массив на экран
//         Console.Write("[");
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i]);
//             if (i < numbers.Length - 1)
//             {
//                 Console.Write(", ");
//             }
//         }
//         Console.WriteLine("]");
//     }
// }
