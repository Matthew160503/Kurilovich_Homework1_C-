// Задание 2
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите два числа");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
else
{
    Console.WriteLine($"Число {num1} равно числу {num2}");
}
*/


//Задание 4
// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите три числа");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2){
    if (num1 > num3){
        Console.WriteLine($"Максимальное число: {num1}");
    } else{
        Console.WriteLine($"Максимальное число: {num3}");
    }
} else {
    if (num2 > num3){
        Console.WriteLine($"Максимальное число: {num2}");
    } else{
        Console.WriteLine($"Максимальное число: {num3}");
    }
}
*/


// Задание 6
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0){
    Console.WriteLine($"{num} - Чётное число");
} else {
    Console.WriteLine($"{num} - Нечётное число");
}
*/


// Задание 8
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;
while (i <= N){ 
    Console.Write(i + " ");
    i +=2;
}
*/