//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


int[] array = new int[12];
int counter = 0;
Random rand = new Random();
for (int y = 0; y < 12 ; y++)
{
  array[y] = rand.Next(-10, 100);
  Console.Write(array[y] + " ");
  if (array[y] >=10 && array[y] <=99) counter++;
  }
Console.WriteLine(" ");
Console.WriteLine("Количество чисел в диапазоне от 10 до 99 равно " + counter);


