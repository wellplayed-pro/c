/*int randomNumber = new Random().Next(0, 100);
int[] array = new int[5];
Array[0] = randomNumber;
for (int i = 0; i < array.Length; i++)
{
  Array[i];
}

int[] FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    Array[i] = i;
  }
return array;

int.Parse("123");
Convert.ToInt32("123");
*/
// Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.


int[] array = new int[10];
int plus = 0;
int minus = 0;------
.
Random rand = new Random();
for (int y = 0; y < 10 ; y++)
{
  array[y] = rand.Next(-9, 10);
  Console.Write(array[y] + " ");
  if (array[y] > 0) plus=plus+array[y];
  if (array[y] < 0) minus=minus+array[y];
}


Console.WriteLine(" ");
Console.WriteLine("Сумма положительных элементов равна " + plus);
Console.WriteLine("Сумма отрицательных элементов равна " + minus);