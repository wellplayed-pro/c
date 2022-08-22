//Задача 2: Задайте массив из 10 элементов и положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] array = new int[10];
int plus = 0;
int minus = 0;
Random rand = new Random();
for (int y = 0; y < 10 ; y++)
{
  array[y] = rand.Next(-9, 10);
  Console.Write(array[y] + " ");
 if (array[y] > 0 || array[y] < 0) array[y]=array[y]*(-1);
  
}
Console.WriteLine("Измененный массив");
Console.WriteLine(string.Join(" ", array));


