//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int N = Convert.ToInt32(Console.ReadLine());
if(N>99)
{
    while(N>999)
    {
        N = N/10;
    }
    int LD = N%10;
    Console.Write(LD);
}
else
    Console.Write("Третьей цифры нет");
