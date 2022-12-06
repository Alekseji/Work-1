/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*double[,] Create2DRandomArray (double rows, double columns)
{
double[,] newArray = new double[rows,columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
newArray[i,j] = new  Random().Next(6, 8);
}
}
return newArray;
}

void Show2DArray (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i,j] + " ");
}
Console.WriteLine();
}
}
Console.WriteLine("Введите количество строк: ");
double rows = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
double columns = Convert.ToDouble(Console.ReadLine());
double[,] myArray = Create2DRandomArray(rows, columns);
Show2DArray(myArray);*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

/*int[,] Create2DRandomArray (int rows, int columns)
{
int[,] newArray = new int[rows,columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
newArray[i,j] = new  Random().Next(0, 25);
}
}
return newArray;
}

void Show2DArray (int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
 for (int j = 0; j < array.GetLength(1); j++)
 {
 Console.Write(array[i,j] + " ");
 }
 Console.WriteLine();
 }
}
int[,] Nummber2DArray (int rows, int columns,int a)
{
int[,] newArray = new int[rows,columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
newArray[i,j] = new  Random().Next(0, 25);
if( a > 0 &&  a < 25 );
else Cnsole.WriteLine("Такого числа нет");
}
Cnsole.WriteLine("Число в массиве");
}
}
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(rows, columns);
Show2DArray(myArray);
Nummber2DArray (myArray);*/


