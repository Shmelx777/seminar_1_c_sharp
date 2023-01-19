// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: "); //Вывод в консоль сообщение
int number = Convert.ToInt32(Console.ReadLine()); //int.Parse || convert.ToInt32()

for(int i=2;i<number;i+=2)
{
    Console.WriteLine(i);
}