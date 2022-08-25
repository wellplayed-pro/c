// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int[,] array)
{
  
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(10,51);
      Console.Write(array[i,j]+ " ");
      
    }
    Console.WriteLine(" ");
  }
  return array;
}
void Middle(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
    double middle = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      middle = middle + array[i, j];
    }
    Console.WriteLine("Среднее арифметическое столбца " + (j+1) + " равно " +(middle /  array.GetLength(0)));
    }
 }


int[,] array = new int[4, 4];

Middle(FillArray(array));

