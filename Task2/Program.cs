//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int max = 0;
Console.WriteLine("Привет! Сейчас я покажу максимальное значение из трех чисел! ");
Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
max = Math.Max(a, Math.Max(b, c)); //Можно было прописать при помощи if и else, но решила попробовать сократить цепочку
Console.WriteLine("max = " + max);