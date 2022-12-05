/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
   
/*int [] CreateArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
       newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
    
}   
void ShowArray(int [] array)
{
    Console.Write("Получившийся массив ->");
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i]+ " "); 
    }
    Console.WriteLine();
  
}
void Positivnumbers (int [] array)
  
{
   int count = 0;
   for (int i = 0; i <array.Length; i++)                
   {
    if (array[i]> 0 ) count ++;
   }
    Console.WriteLine($"количество положительных чисел {count}");
}
Console.WriteLine("введите размер массива");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max=Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(a,min,max);
ShowArray(myArray);
Positivnumbers(myArray);*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/*double Intersectionoflines (int b1, int k1,int b2, int k2);
   double x = k1 * x + b1;
   double y = k2 * x + b2;
   for (int x = -0,5; x < 0,5; x++)
   {
   for (int y = -0,5; y < 0,5; y++)
   {
   if (k1 * x + b1 =-0,5 && k2 * x + b2=-0,5);
   else Console.WriteLine("Прямые не пересекаются");
   }
   Console.WriteLine(Intersectionoflines ($"X = {x}, Y = {y}")); 
}
Console.WriteLine("Imput numberb1");
double numberb1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput numberk1");
double numberk1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput numberb2");
double numberb2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput numberk2");
double numberk2=Convert.ToInt32(Console.ReadLine());*/


