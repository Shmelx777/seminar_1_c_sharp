﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое число: "); //Вывод в консоль сообщение
int numberA = Convert.ToInt32(Console.ReadLine()); //int.Parse || convert.ToInt32()

Console.Write("Введите второе число: "); //Вывод в консоль сообщение
int numberB = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите третье число: "); //Вывод в консоль сообщение
int numberC = Convert.ToInt32(Console.ReadLine()); 

int max = numberA;

if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

System.Console.WriteLine($"Самое большое число {max}");

