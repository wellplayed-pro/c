//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int FillArray(int[] array)
{
  int counter = 0;
  for (int i = 0; i < array.Length; i++)
  {
    array[i]=  int.Parse(Console.ReadLine()) ;
    if (array[i]>0) counter++;
  }
  Console.WriteLine(string.Join(", ", array));
  return counter;
}


int m;
Console.WriteLine("Введите количество чисел, которые будете вводить");
m=int.Parse(Console.ReadLine());
int [] array = new int[m] ;
Console.WriteLine(" ");
Console.WriteLine("Количество чисел больше 0 равно " + FillArray(array));