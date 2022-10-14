// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
// for (int k=0; k<wert.GetLength(0); k++)
// {
//     for (int l=0; l<wert.GetLength(1); l++)
//     {
//         int sum=wert[k,l];
//         for (int e=l+1;e<wert.GetLength(1); e++)
//         {
//             if (sum<wert[k,e])
//             {
//                 int temp=wert[k,l];
//                 wert[k,l]=wert[k,e];
//                 wert[k,e]=temp;
//             }
//         }
//     }
// }
// Console.WriteLine(" ");
// Print(wert);



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

// for (int k=0; k<wert.GetLength(1); k++)
// {
//     int b=-1;
//     for (int z=0; z<wert.GetLength(0); z++)
//     {
//         int j=0;
//         b++;
//         int factor=0;
//         for (int i=0; i<wert.GetLength(1); i++)
//         {
//             factor=wert[z,j]*arr[j,z];
//             j++;
//             war[b,k]=war[b,k]+factor;
//         }
//     }
// }
// Console.WriteLine(" ");
// Print(war);




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// Console.Write("Введите количество строк массива - ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива - ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество рядов массива - ");
// int q = Convert.ToInt32(Console.ReadLine());
// int[,,] array= new int [a,b,q];
// for (int i=0; i<array.GetLength(0); i++)
// {
//     for (int j=0; j<array.GetLength(1); j++)
//     {
//         for (int k=0; k<array.GetLength(2); k++)
//         {
//             int z=new Random().Next(10, 100);
//             for (int e=0; e<=i; e++)
//             {
//                 for (int r=0; r<=j; r++)
//                 {
//                     for (int f=0; f<=k; f++)
//                     {
//                         if (z==array[e,r,f])
//                         {
//                             z=new Random().Next(10, 100);
//                         }
//                     }
//                 }
//             }
//             array[i,j,k]=z;
//         }
//     }
// }
// for (int u=0; u<array.GetLength(0); u++)
// {
//     for (int g=0; g<array.GetLength(1); g++)
//     {
//         for (int y=0; y<array.GetLength(2); y++)
//         {
//             Console.Write($"{array[u,g,y]} ({u}, {g}, {y}); ");
//         }
//         Console.WriteLine(" ");
//     }
//     Console.WriteLine(" ");
// }



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] arr = new int [4,4];
Console.Write("Введите начальное значение - ");
int f = Convert.ToInt32(Console.ReadLine());
arr[0,0]=f;
for (int i=1; i<4; i++)
{
    arr[0,i]=arr[0,i-1]+1; //0;1 4, 0;2 5, 0;3 6,
}
for (int j=1; j<4 ; j++)
{
    arr[j,3]=arr[j-1,3]+1;  // 1;3 7, 
}
for (int k=2; k>-1; k=k-1)
{
    arr[3,k]=arr[3,k+1]+1;
}
for (int m=2; m>0; m=m-1)
{
    arr[m,0]=arr[m+1,0]+1;
}
for (int y=1; y<3; y++)
{
    arr[1,y]=arr[1,y-1]+1;
}
arr[2,2]=arr[1,2]+1;
arr[2,1]=arr[2,2]+1;
Print(arr);

