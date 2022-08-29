// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = new Random().Next(10, 100);
        Console.Write(array[i, j, k] + "( " + i + " , " + j + " , " + k + " ) ");
      }
      Console.WriteLine(" ");
    }
  }
  return array;
}

int[,,] array = new int[2, 2, 2];
Console.WriteLine("Массив и индексы");
FillArray(array);