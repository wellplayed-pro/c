// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double[8];
double max = 0;
double min = 1000;
double result = 0;
Random rand = new Random();
for (int y = 0; y < rand.Next(1, 8); y++)
{
  array[y] = Math.Round(rand.NextDouble()*200,2);
  Console.Write(array[y] + " ");
  if (array[y]>max) max=array[y];
  if (array[y]<min) min = array[y];
}
result = max - min;
Console.WriteLine(" ");
Console.WriteLine(min);
Console.WriteLine("Разница минимума и максимума " + Math.Round(result,2));
