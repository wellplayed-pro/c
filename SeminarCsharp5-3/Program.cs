// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int [] array = new int[8] ;

int[] FillArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
  {
    array[i]=  new Random().Next(0,100) ;
  }
  Console.WriteLine(string.Join(", ", array));
  return array;
}

int MinMax(int[] array)
{
int max = 0;
int min = 1000;
int result = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > max) max = array[i];
  if (array[i] < min) min = array[i];
}
result = max-min;
Console.WriteLine(min);
Console.WriteLine(max);
return result;
}

Console.WriteLine(MinMax(FillArray(array)));
