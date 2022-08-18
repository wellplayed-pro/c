// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[8];
int counter = 0;
Random rand = new Random();
for (int y = 0; y < rand.Next(1, 8); y++)
{
  array[y] = rand.Next(1, 1000);
  Console.Write(array[y] + " ");
  if (array[y] % 2==0) counter++;
 
}
Console.WriteLine(" ");
Console.WriteLine("Количество четных элементов равно " + counter);