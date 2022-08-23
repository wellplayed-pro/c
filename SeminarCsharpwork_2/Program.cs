// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
//Элементы одномерного массива задаются случайно и лежат в промежутке от -10 до 10

//[1, -5, 8, 4, -9] -> 4.33

double FillArray(int[] array)
{
  double sum=0;
  double result = 0;
  int counter = 0;
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-10, 11);
    if (array[i] > 0)
    {
      sum = sum + array[i];
      counter++;
    }
  }
  Console.WriteLine(string.Join(", ", array));
result=Math.Round(sum/counter,2);
  return result;

}

int [] array = new int[8] ;
Console.WriteLine (FillArray(array));