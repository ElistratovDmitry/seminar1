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
Console.WriteLine("");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("ЗАДАЧА 6 ДЗ");
Console.WriteLine("введи число ");
int n6=int.Parse(Console.ReadLine());
if (n6%2==0) Console.WriteLine("число четное");
else Console.WriteLine("число нечетное");
Console.WriteLine("");
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("ЗАДАЧА 8 ДЗ");
Console.WriteLine("введи число ");
int n8=int.Parse(Console.ReadLine());
int count=2;
Console.WriteLine("четнве числа:");
while (count<=n8) {
Console.WriteLine(count);
count=count+2;
}


//while (count<=n8);
//{ 
  //  if (count%2==0) Console.Write( count );
    //count=count+1;
//}
Console.WriteLine("end");    
