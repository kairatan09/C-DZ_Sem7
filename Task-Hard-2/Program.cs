// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
// причем чтобы каждый элемент гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.


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

int[,] Rand(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int m = new Random().Next(0, array.GetLength(0) - 1);
      int n = new Random().Next(0, array.GetLength(1) - 1);
      (array[i, j], array[m, n]) = (array[m, n], array[i, j]);
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
  Console.WriteLine("Массив заполненный случайными числами:");
  PrintArray(array);
  Console.WriteLine("\nПеремешанный массив на основе случайности:");
  PrintArray(Rand(array));
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}

