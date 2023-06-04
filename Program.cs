// //Задайте двумерный массив размером ХУ заполненный случайными вещемтвенными числами (сотые)
// double[,] DoubleRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];
//     for ( int i=0; i<rows; i++)
//     {
//         for (int j=0; j<columns; j++)
//         {
//           array[i,j]= Convert.ToDouble(new Random().Next(minValue,maxValue))/100;
//         }
//     }
//     return array;
// }
// void PrintDoubleArray(double[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for ( int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ") ;
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// PrintDoubleArray(DoubleRandomArray(rows,columns,minValue,maxValue));

// Задайте двумерный массив. Найти средне арифмитическое элементов в каждом столбце

// int[,] Creat2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for ( int i=0; i<rows; i++)
//     {
//         for (int j=0; j<columns; j++)
//         {
//           array[i,j]= new Random().Next(minValue,maxValue);
//         }
//     }
//     return array;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for ( int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ") ;
//         }
//         Console.WriteLine();
//     }
    
// }
//  void sumelenCount(int[,] array)
// {
//     for (int j=0; j<array.GetLength(1);j++)
//     {
//         double sum=0;
//         for ( int i=0; i<array.GetLength(0); i++)
//         {
//             sum+=array[i,j];
//         }
//         Console.Write($"{sum/array.GetLength(0)} "); 
//     } 
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray= Creat2DRandomArray(rows,columns,minValue,maxValue);
// Print2DArray(myArray);
// sumelenCount(myArray);

// Напишите программу поиска элемента в моссиве по его индексу и возвращает его 
// или же указывает, что такого элемента нет.

int[,] Creat2DRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int count=0;
    for ( int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
          array[i,j]= count++;
        }
    }
    return array;
}
void Print2DArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for ( int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ") ;
        }
        Console.WriteLine();
    }
}
void NumFind(int num , int[,] array)
{
    int count=0;
    for (int i=0; i<array.GetLength(0);i++)
    {
        for ( int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j]==num) 
            {
               int m=i; int n=j; count++;
               Console.WriteLine($"Числ {num} имеет координаты[{m},{n}]");
            }
         }       
    } if (count==0)Console.WriteLine($"Такого числа в массиве нет"); 
}   

Print2DArray(Creat2DRandomArray(5,5));
Console.WriteLine("input namber");
int num= Convert.ToInt32(Console.ReadLine());
NumFind(num,Creat2DRandomArray(5,5));

