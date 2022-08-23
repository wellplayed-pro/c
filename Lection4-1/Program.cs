

int[] FillArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
  {
    array[i]=  new Random().Next(0,100) ;
  }
  Console.WriteLine(string.Join(", ", array));
  return array;
}

int Chet(int[] array)
{
  int counter = 0;
  for (int i = 0; i < array.Length; i++)
{
 if (array[i] % 2==0) counter++;

  }
return counter;
}
int [] array = new int[8] ;
Console.WriteLine(" ");
Console.WriteLine("Количество четных элементов равно " + Chet(FillArray(array)));