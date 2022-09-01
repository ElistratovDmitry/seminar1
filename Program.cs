// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("ЗАДАЧА 2 ДЗ");
Console.WriteLine("введи число 1");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("введи число 2");
int number2=int.Parse(Console.ReadLine());

if (number1==number2) {
    Console.WriteLine("числа равны");
}
    else {
        if (number1<number2) {
            Console.WriteLine($"второе число {number2} больше, а первое число {number1} меньше");
        }
    else 
    Console.WriteLine($"первое число {number1} больше, а второе число {number2} меньше");
}
Console.WriteLine("");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

 Console.WriteLine("ЗАДАЧА 4 ДЗ");   
Console.WriteLine("введи число 1");
int n1=int.Parse(Console.ReadLine());
Console.WriteLine("введи число 2");
int n2=int.Parse(Console.ReadLine());
Console.WriteLine("введи число 3");
int n3=int.Parse(Console.ReadLine());
int maximum = Math.Max(n1, n2);
maximum = Math.Max(maximum, n3);
Console.WriteLine($"максимальное число {maximum}");
