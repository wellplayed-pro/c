// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[8];
int sum = 0;
Random rand = new Random();
for (int y = 0; y < rand.Next(1, 8); y++)
{
  array[y] = rand.Next(-100, 100);
  Console.Write(array[y] + " ");
  if (y % 2==0) sum=sum+array[y];
 
}
Console.WriteLine(" ");
Console.WriteLine("Сумма нечетных элементов равна " + sum);