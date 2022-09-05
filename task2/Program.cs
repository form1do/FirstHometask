
Console.WriteLine("Добро пожаловать в программу сравнения двух чисел");
Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber>SecondNumber)
{System.Console.WriteLine($"Число {FirstNumber} больше числа {SecondNumber}");

}
if (FirstNumber==SecondNumber){
    System.Console.WriteLine("Оба числа равны");
}
else
System.Console.WriteLine($"Число {FirstNumber} меньше числа {SecondNumber}");