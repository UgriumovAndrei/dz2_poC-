// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// Это по-моему самый простой вариант с проверкой символа в строке

// Console.WriteLine("Введите цифру от 1 - 7");
//string n = Console.ReadLine();
//if("67".Contains(n))
//    Console.Write("ДА, ГУЛЯЕМ!");
//else
//    Console.Write("Нет, сидим учимся :(");

// Но на семинаре нам сказали, что по идее можно через массив решать
 
int[]WeekendChislaNoyabrya2022 = {5, 6, 12, 13, 19, 20, 26, 27};
Console.WriteLine("Введите любое число ноября 2022");
int find = Convert.ToInt32(Console.ReadLine());
if (find<0 || find>30)
    Console.Write("такого дня нет в ноябре 2022");
else
{
    int count = WeekendChislaNoyabrya2022.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(WeekendChislaNoyabrya2022[index]==find)    
    {
        position = index;
        break;
    }
    index++;
    }
    if(position != -1)
        Console.Write($"{find} это выходной день");
    else
        Console.Write($"{find} это рабочий день");
}







