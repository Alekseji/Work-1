/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


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
void Evennumbers (int [] array)
{
    int even = 0;
        for (int i = 0; i <array.Length; i++)                
    {
    if (array[i]>100 && array[i]<1000);
    else Console.WriteLine("Массив задан неправильно");
    if(array[i] % 2 ==0) even++;
    
    }
    Console.WriteLine($"количество четных чисел {even}");
}
Console.WriteLine("введите размер массива");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max=Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(a,min,max);
ShowArray(myArray);
Evennumbers(myArray);*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
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
void Oddnumbers (int [] array)
{
    int odd = 0;
        for (int i = 0; i <array.Length; i++)                
    {
    if (array[i]>0);
    else Console.WriteLine("Массив задан неправильно");
    if(array[i] % 2 != 0) odd = array[i] + odd;       
    }
    Console.WriteLine($"Сумма элементов массива на нечетных позициях {odd}");
}
Console.WriteLine("введите размер массива");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max=Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(a,min,max);
ShowArray(myArray);
Oddnumbers(myArray);*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

