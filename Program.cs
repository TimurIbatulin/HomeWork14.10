﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void FillArray (int[,] array, int z, int f)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int s=0; s<array.GetLength(1); s++)
        {
            array[i,s]=new Random().Next(z, f);
        }
    }

}

void Print ( int[,] array)
{
    for (int p=0; p<array.GetLength(0); p++)
    {
        for (int o=0; o<array.GetLength(1); o++)
        {
            Console.Write ($"{array[p,o]} ");
        }
        Console.WriteLine (" ");
    }
}

Console.Write("Введите количество строк массива - ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива - ");
int t = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значение диапазона случайных чисел для наполнения массива - ");
int q = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значение диапазона случайных чисел для наполнения массива - ");
int w = Convert.ToInt32(Console.ReadLine());
int [,]wert=new int[y,t];
FillArray(wert, q, w);
Print(wert);
for (int k=0; k<wert.GetLength(0); k++)
{
    for (int l=0; l<wert.GetLength(1); l++)
    {
        int sum=wert[k,l];
        for (int e=l+1;e<wert.GetLength(1); e++)
        {
            if (sum<wert[k,e])
            {
                int temp=wert[k,l];
                wert[k,l]=wert[k,e];
                wert[k,e]=temp;
            }
        }
    }
}
Console.WriteLine(" ");
Print(wert);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк массива - ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива - ");
// int t = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нижнее значение диапазона случайных чисел для наполнения массива - ");
// int q = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите верхнее значение диапазона случайных чисел для наполнения массива - ");
// int w = Convert.ToInt32(Console.ReadLine());
// int [,]wert=new int[y,t];
// FillArray(wert, q, w);
// Print(wert);
// int sum=0;
// int er=1000000;
// int str=0;
// for (int k=0; k<wert.GetLength(0); k++)
// {
//     for (int l=0; l<wert.GetLength(1); l++)
//     {
//         sum=sum+wert[k,l];
//     }
//     if (sum<er)
//     {
//         er=sum;
//         str=k;
//     }
//     sum=0;
// }
// Console.Write($"Наименьшая сумма элементов находится в строке {str+1} и равна {er}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите количество строк массива - ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива - ");
// int t = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите нижнее значение диапазона случайных чисел для наполнения массива - ");
// int q = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите верхнее значение диапазона случайных чисел для наполнения массива - ");
// int w = Convert.ToInt32(Console.ReadLine());
// int [,]wert=new int[y,t];
// int [,]arr=new int [y,t];
// int [,]war=new int [y,t];
// FillArray(wert, q, w);
// FillArray(arr, q, w);
// Print(wert);
// Console.WriteLine(" ");
// Print(arr);
// int temp2=0;
// int s=0;
// int v=0;
// for (int k=0; k<wert.GetLength(0); k++)
// {
//     for (int l=0;l<wert.GetLength(1); l++)
//     {
//         int temp1=wert[k,l]*arr[l,k];
//         temp2=temp2+temp1;
//         if (l==wert.GetLength(0))
//         {
//             war[s,v]=temp2;
//             temp2=0;
//             Console.Write($"{war[s,v]}");
//             s++;
//         }
//         Console.WriteLine($"{temp2}");
//     }
// }




//int temp2=wert[k,l+1]*arr[m+1,n]+wert[k,l+2]*arr[m+2,n]




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07