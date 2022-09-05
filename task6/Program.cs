// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать в программу проверки на четность");
System.Console.WriteLine("ВВедите число");
int UserNumber = Convert.ToInt32(Console.ReadLine());
if (UserNumber % 2 == 0){
    System.Console.WriteLine($"Число {UserNumber} -> четное");
}
else
{
    System.Console.WriteLine($"Число {UserNumber} -> нечетное");
}