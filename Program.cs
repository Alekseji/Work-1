/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*int Exponentiation (int a, int b)
{
    int stepen=b;
    for (int i = 0; i<=b; i++)
    {
    stepen = Convert.ToInt32(Math.Pow(a,b));   
    }
    return stepen;
}
Console.WriteLine("Imput number 1");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number 2");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Exponentiation(a,b));*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*int Sumnumber (int a)
{
    int sum = 0;
   for (int i = 0; i <=a; i++)
   {    
   sum=sum + a % 10;
   a=a / 10;
   }
   return sum;
}
Console.WriteLine("Imput number");
int number=Convert.ToInt32(Console.ReadLine());
int result = Sumnumber(number);
Console.WriteLine(result);*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
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
Console.WriteLine("введите размер массива");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max=Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(a,min,max);
ShowArray(myArray);*/
