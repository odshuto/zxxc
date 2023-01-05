//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

//6 -> да

// Дз №10
int number_3 = 0; 
Console.WriteLine("№10");
Console.Write("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
number_3 = number % 100 / 10;
Console.WriteLine($"2-e число:{number_3}");

// №13
int number_1 = 0; 
Console.WriteLine("№10");
Console.Write("Введите трехзначное число : ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 < 100)
    Console.WriteLine("Это число не трехзначное)");
else
    number_1 = number2 % 100 % 10;
    Console.WriteLine($"3-e число:{number_1}");

//№15
Console.WriteLine("№15");
Console.Write("Введите день недели по счету : ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number3 > 5)
    Console.WriteLine("Yes:)");
else
    Console.WriteLine("No:(");