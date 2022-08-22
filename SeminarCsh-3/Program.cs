//Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


int[] array = new int[8];
int count = 0;
Console.WriteLine("Введите число для поиска в массиве");
int number = int.Parse(Console.ReadLine());
Random rand = new Random();
for (int y = 0; y < 8 ; y++)
{
  array[y] = rand.Next(1, 10);
  Console.Write(array[y] + " ");
  if (array[y] == number) count=count+1;
}

Console.WriteLine("Количество повторений указанного числа в массиве: " + count);