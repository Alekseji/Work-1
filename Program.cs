/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
/*int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
 int[,] newArray = new int[rows, columns];

 for (int i = 0; i < rows; i++)
 {
   for(int j = 0; j < columns; j++)
  {
   newArray[i,j] = new Random().Next(minValue,maxValue + 1);
  }
 }
return newArray;
}

void Show2DArray(int[,] array)
{
 for(int i = 0;i < array.GetLength(0) ;i++ )
 {
  for(int j = 0; j < array.GetLength(1); j++)
  {
   Console.Write(array[i,j] + " ");
  }
  Console.WriteLine();
 }
}
void Findmaxelement (int[,] array, int minValue, int maxValue)
{
    for(int i = maxValue; i < array.GetLength(0);i++ )
    {
        for(int j = maxValue; j < array.GetLength(1); j++)
        array [i,j] = array [maxValue, minValue];
        
    }
     {
        Console.Write(array[minValue,maxValue] + " ");
     }
     
     Console.WriteLine();
}
Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2DArray(rows,columns,min,max);
Show2DArray(myArray);
Findmaxelement(myArray,min,max);
Console.WriteLine();
Show2DArray(myArray);*/




