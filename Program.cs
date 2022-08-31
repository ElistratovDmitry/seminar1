// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


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

    


