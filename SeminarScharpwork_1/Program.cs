// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
//Элементы одноме массива задаются случайно и лежат в промежутке от -10 до 10
//

void FillArray(int[] array)
{
  int b = array.Length - 1;
  int[] array1 = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    array[i]=  new Random().Next(-10,11) ;
    array1[b] = array[i];
    b--;
  }
  Console.WriteLine(string.Join(", ", array));
  Console.WriteLine(string.Join(", ", array1));
  
}

int [] array = new int[7] ;
FillArray(array);