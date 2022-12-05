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


