// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем двумерный массив
//         int[,] array = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4}
//         };

//         // Проходим по каждой строке массива
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             // Сортируем текущую строку по убыванию
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
//                 {
//                     if (array[i, k] < array[i, k + 1])
//                     {
//                         // Меняем местами элементы, если текущий больше следующего
//                         int temp = array[i, k];
//                         array[i, k] = array[i, k + 1];
//                         array[i, k + 1] = temp;
//                     }
//                 }
//             }
//         }

//         // Выводим упорядоченный массив
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем прямоугольный двумерный массив
//         int[,] array = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4},
//             {5, 2, 6, 7}
//         };

//         int minSum = int.MaxValue; // Изначально устанавливаем минимальную сумму как максимальное возможное значение
//         int minSumRowIndex = -1;   // Индекс строки с минимальной суммой элементов

//         // Проходим по каждой строке массива
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int currentSum = 0; // Переменная для хранения суммы элементов текущей строки

//             // Считаем сумму элементов в текущей строке
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 currentSum += array[i, j];
//             }

//             // Если текущая сумма меньше минимальной, обновляем минимальную сумму и индекс строки
//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minSumRowIndex = i;
//             }
//         }

//         // Выводим номер строки с наименьшей суммой элементов
//         Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRowIndex + 1));
//     }
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] matrix1 = {
//             {2, 4},
//             {3, 2}
//         };

//         int[,] matrix2 = {
//             {3, 4},
//             {3, 3}
//         };

//         int rows1 = matrix1.GetLength(0);
//         int cols1 = matrix1.GetLength(1);

//         int rows2 = matrix2.GetLength(0);
//         int cols2 = matrix2.GetLength(1);

//         if (cols1 != rows2)
//         {
//             Console.WriteLine("Умножение матриц невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
//         }
//         else
//         {
//             int[,] result = new int[rows1, cols2];

//             for (int i = 0; i < rows1; i++)
//             {
//                 for (int j = 0; j < cols2; j++)
//                 {
//                     int sum = 0;

//                     for (int k = 0; k < cols1; k++)
//                     {
//                         sum += matrix1[i, k] * matrix2[k, j];
//                     }

//                     result[i, j] = sum;
//                 }
//             }

//             Console.WriteLine("Результирующая матрица:");

//             for (int i = 0; i < rows1; i++)
//             {
//                 for (int j = 0; j < cols2; j++)
//                 {
//                     Console.Write(result[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,,] array = new int[2, 2, 2];
//         int number = 10; // Начальное значение для двузначных чисел

//         // Заполнение массива неповторяющимися двузначными числами
//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 for (int k = 0; k < 2; k++)
//                 {
//                     array[i, j, k] = number;
//                     number++; // Увеличиваем значение для следующего числа
//                 }
//             }
//         }

//         // Вывод массива с добавлением индексов
//         for (int i = 0; i < 2; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 for (int k = 0; k < 2; k++)
//                 {
//                     Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
//                 }
//             }
//         }
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int n = 4; // Размер массива (4x4)
//         int[,] array = new int[n, n];

//         int value = 1; // Начальное значение для заполнения

//         int left = 0, right = n - 1, top = 0, bottom = n - 1;

//         while (left <= right && top <= bottom)
//         {
//             // Заполняем верхнюю строку слева направо
//             for (int i = left; i <= right; i++)
//             {
//                 array[top, i] = value++;
//             }
//             top++;

//             // Заполняем правый столбец сверху вниз
//             for (int i = top; i <= bottom; i++)
//             {
//                 array[i, right] = value++;
//             }
//             right--;

//             // Заполняем нижнюю строку справа налево
//             for (int i = right; i >= left; i--)
//             {
//                 array[bottom, i] = value++;
//             }
//             bottom--;

//             // Заполняем левый столбец снизу вверх
//             for (int i = bottom; i >= top; i--)
//             {
//                 array[i, left] = value++;
//             }
//             left++;
//         }

//         // Выводим массив
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write($"{array[i, j]:D2} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }