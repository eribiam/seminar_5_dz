// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int count = 0;
// Console.Write("[ ");
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     if (array[i] % 2 == 0) count++;
//     Console.Write($"{array[i]} ");
// }    
// Console.WriteLine("]");
// System.Console.WriteLine($"Колличество чётных чисел в массиве = {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// System.Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [size];
// int sum = 0;
// System.Console.Write("[ ");
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100);
//     System.Console.Write($"{array[i]} ");
//     if (i == 0 || i % 2 == 0) sum += array[i];
// }
// System.Console.WriteLine("]");
// System.Console.WriteLine($"Сумма всех элементов, стоящих на нечётных позициях = {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76