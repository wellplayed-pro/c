// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)
{
  double middle=0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(10,51);
      Console.Write(array[i,j]+ " ");
      middle = middle + array[i, j];

    }
    Console.WriteLine(" ");
    Console.WriteLine("Среднее арифметическое строчки " + (i+1) + " равно " +(middle /  array.GetLength(0)));
  }
 
}
int[,] array = new int[4, 4];

FillArray(array);

