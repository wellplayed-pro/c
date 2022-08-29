
/*
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
Console.WriteLine("Количество четных элементов равно " + Chet(FillArray(array)));*/


double[,] coeff = new double[2, 2];
double[] pointxy = new double[2];
void FillArray(double[,] coeff)
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Input k{i + 1}:");
            else Console.Write($"Input b{i + 1}:");
            coeff[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Shlyapa(double[,] function)
{
    pointxy[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[0, 1]);
    pointxy[1] = pointxy[0] * coeff[0, 0] + coeff[0, 1];
    return pointxy;
}

void Print(double[,] function)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[1, 1] == coeff[0, 1])
    {
        Console.WriteLine("Lines match!");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[1, 1] != coeff[0, 1])
    {
        Console.WriteLine("Lines parallel!");
    }
    else
    {
        Shlyapa(coeff);
        Console.Write($"Point intersection:[{pointxy[0]},{pointxy[1]}]");
    }
}


FillArray(coeff);
Print(coeff);


/*
double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);*/