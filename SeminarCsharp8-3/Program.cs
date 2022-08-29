// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(1,10);
      Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine(" ");
  }
  return array;
}
void Multi(int[,] array, int[,] array1 )
{
  int[,] matr = new int[ array.GetLength(0),  array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      matr[i, j] = array[i, j] * array1[i, j];
      Console.Write(matr[i, j]+ " ");
    }
    Console.WriteLine(" ");
  }
}
  
int[,] array = new int[4, 4];
int[,] array1 = new int[4, 4];
Console.WriteLine("Первый двумерный массив");
FillArray(array);
Console.WriteLine("Второй двумерный массив");
FillArray(array1);
Console.WriteLine("Произведение двух двумерных массивов");
Multi(array, array1);