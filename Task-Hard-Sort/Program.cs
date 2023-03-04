// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(1, 100);
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j],2} \t");
    Console.WriteLine();
  }
}


int[,] SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int MaxIndexi = i;
      int MaxIndexj = j;
      for (int CurrentIndexi = i; CurrentIndexi < array.GetLength(0); CurrentIndexi++)
      {
        if (CurrentIndexi == i)
        {
          for (int CurrentIndexj = j; CurrentIndexj < array.GetLength(1); CurrentIndexj++)
          {
            if (array[CurrentIndexi, CurrentIndexj] > array[MaxIndexi, MaxIndexj])
            {
              MaxIndexi = CurrentIndexi;
              MaxIndexj = CurrentIndexj;
            }

          }
        }
        else
        {
          for (int CurrentIndexj = 0; CurrentIndexj < array.GetLength(1); CurrentIndexj++)
          {
            if (array[CurrentIndexi, CurrentIndexj] > array[MaxIndexi, MaxIndexj])
            {
              MaxIndexi = CurrentIndexi;
              MaxIndexj = CurrentIndexj;
            }
          }
        }
      }
      (array[i, j], array[MaxIndexi, MaxIndexj]) = (array[MaxIndexi, MaxIndexj], array[i, j]);
    }
  }
  return array;
}



try
{
  Console.WriteLine("Введите количество строк");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите количество столбцов");
  int cols = Convert.ToInt32(Console.ReadLine());
  int[,] array = new int[rows, cols];
  FillArray(array);
  Console.WriteLine("\nЗаполненный случайными числами массив");
  PrintArray(array);
  Console.WriteLine("\nОтсортированный массив");
  PrintArray(SortArray(array));
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}
