Console.WriteLine("Добро пожаловать в программу нахождения максимального из трех числа ");
Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = FirstNumber;
if (max<SecondNumber){
    max=SecondNumber;
}
if (max<ThirdNumber){
    max=ThirdNumber;
}
System.Console.WriteLine($"Большее число -> {max}");