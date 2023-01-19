// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: "); //Вывод в консоль сообщение
int numberA = Convert.ToInt32(Console.ReadLine()); //int.Parse || convert.ToInt32()
Console.Write("Введите второе число: "); //Вывод в консоль сообщение
int numberB = Convert.ToInt32(Console.ReadLine()); 
int max;
if(numberA > numberB){
    max = numberA;
    Console.WriteLine($"Первое число {max} больше чем второе {numberB} ");
}
else if(numberA < numberB){
    max = numberB;
    Console.WriteLine($"Второе число {max} больше чем первое {numberA}");
}
else{
    Console.WriteLine("Первое и второе число равны!");
}


