// Задача 34:

//  {
//         // Создаем генератор случайных чисел
//         Random random = new Random();

//         // Создаем массив и заполняем его случайными трехзначными числами
//         int[] numbers = new int[4]; // Можете изменить размер массива по вашему желанию
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000); // Генерируем случайное трехзначное число
//         }

//         // Подсчитываем количество четных чисел
//         int evenCount = 0;
//         foreach (int number in numbers)
//         {
//             if (number % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine("Сгенерированный массив чисел:");
//         foreach (int number in numbers)
//         {
//             Console.Write(number + " ");
//         }
//         Console.WriteLine();
//         Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
//     }



// Задача 36:

//  {
//         // Создаем массив с случайными числами
//         int[] array = { 3, 7, 23, 12 }; // Замените этот массив на свой

//         int sum = 0;

//         // Проходим по элементам массива на нечетных позициях
//         for (int i = 0; i < array.Length; i += 2)
//         {
//             sum += array[i];
//         }

//         Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
//     }



// Задача 38:

// {
//         double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

//         double min = numbers.Min();
//         double max = numbers.Max();

//         double difference = max - min;

//         Console.WriteLine("Минимальный элемент: " + min);
//         Console.WriteLine("Максимальный элемент: " + max);
//         Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
//     }
