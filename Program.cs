// ______________________________Задача 19______________________________
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// using System;  
// public class Exercise38 
// {
//       public static void Main()
// {
//     int num,r,sum=0,t;
     
     
//      Console.Write("\n\n");
//     Console.Write("Check whether a number is a palindrome or not:\n");
//     Console.Write("------------------------------------------------");
//     Console.Write("\n\n");    
//     Console.Write("Введите число: ");
//     num = Convert.ToInt32(Console.ReadLine());    
//     for(t=num;num!=0;num=num/10){
//          r=num % 10;
//          sum=sum*10+r;
//     }
//     if(t==sum)
//          Console.Write("{0} Это полидром",t);
//     else
//          Console.Write("{0} Это не палидром",t);
//      }     
// }


// ______________________________Задача 21_______________________________
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");


// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// _______________________Задача 23___________________________
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int count=1;

while(num>=count)
{
    Console.WriteLine(Math.Pow(count,3));
    count=count+1;
}

