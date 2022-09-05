// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать в программу составления ряда четных чисел от 1 до N");
System.Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Ниже ряд четных чисел от 1 до {Number}");
int x = 1;
while (x<Number){
if (x % 2 == 0){
    System.Console.Write($" {x}");
}
x = x+1;
}
