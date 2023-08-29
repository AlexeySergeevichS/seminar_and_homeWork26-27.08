/* Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).
 */
int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void Diapozon(int quarter)
{
    if (quarter == 1)
        System.Console.WriteLine("X>0 и Y>0");
    else if (quarter == 2)
        System.Console.WriteLine("X<0 и Y>0");
    else if (quarter == 3)
        System.Console.WriteLine("X<0 и Y<0");
    else if (quarter == 4)
        System.Console.WriteLine("X>0 и Y<0");
    else
        System.Console.WriteLine("Ввели не четверть");
}
Diapozon(InputNum("Введи четверть: "));