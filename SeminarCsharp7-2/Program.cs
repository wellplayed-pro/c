// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int[,] array)
{
  int counter=0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(10,20);
      Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine(" ");
  }
  return array;
}
void FindNumber(int[,] array, int number)
{
  int counter = 0;
   for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == number)
      {
        Console.WriteLine("Число "+number+ " находится на позиции (строка/столбец) ["+(i+1)+ " , " + (j+1) +"] ");
        counter++;
      }
      
    }
  }
  if (counter ==0) Console.WriteLine("такое число отсутствует в двумерном массиве");
}




int[,] array = new int[4, 4];
Console.WriteLine("Введите число для поиска в массиве");
int number= int.Parse (Console.ReadLine());
FindNumber(FillArray(array),number);

