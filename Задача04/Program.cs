/* 
Напишите программу, которая принимает на вход число (N) и
выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1, 4
 */

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void Squares(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int res = (int)Math.Pow(i, 2);
        if (i != num)
            Console.Write($"{res}, ");
        else
            Console.Write($"{res}.");

    }
}
int n = InputNum("Введи число: ");
Squares(n);