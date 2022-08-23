//Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

int FillArray(int[,] array)
{
  int diag = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(-10, 11);
      Console.Write(array[i, j] + " ");
      if (i==j) diag=diag+array[i, j];
    }
    Console.WriteLine(" ");
  }
  return diag;
}

int [,] array = new int[4,4] ;
Console.WriteLine (FillArray(array));