// Задача 10: Напишите программу, которая принимает на вход трёхзн число
// и на выходе показывает вторую цифру этого числа.

int N = Convert.ToInt32(Console.ReadLine());
int LastD = (N / 10) % 10;
Console.Write(LastD);