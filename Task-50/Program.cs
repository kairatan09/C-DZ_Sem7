// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] array = new int[,]
{
{1, 4, 7, 2 },
{5, 9, 2, 3 },
{8, 4, 2, 4 },
};


void FindPositionElement(int[,] array, int value)
{
  string res1 = "";
  int res2 = 0;
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == value)
        res1 += $"array[{i}, {j}] ";
      else
        res2++;
    }
  if (res2 < array.GetLength(0) * array.GetLength(1))
    Console.WriteLine(res1);
  else
    Console.WriteLine("Такого числа в массиве нет.");
}


try
{
  Console.WriteLine("Введите значение элемента в массиве:\t");
  int element = Convert.ToInt32(Console.ReadLine());
  FindPositionElement(array, element);
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}
