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

