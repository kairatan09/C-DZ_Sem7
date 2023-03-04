﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7    -2  -0,2
// 1  -3,3     8  -9,9
// 8   7,8  -7,1     9


void FillArray(double[,] array)
{
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = rnd.NextDouble();
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]} \t");
    Console.WriteLine();
  }
}


try
{
  Console.WriteLine("Введите количество строк");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите количество столбцов");
  int cols = Convert.ToInt32(Console.ReadLine());
  double[,] array = new double[rows, cols];
  FillArray(array);
  Console.WriteLine();
  PrintArray(array);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}