// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
Random rand = new Random();
for (int y = 0; y < rand.Next(1, 8); y++)
{
     array[y] = rand.Next(1, 21);

  Console.Write(array[y]+" ");
}


  