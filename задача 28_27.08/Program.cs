/* Задача 28: Напишите программу, которая принимает на
 вход число N и выдаёт произведение чисел от 1 до N. */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Fact(int num)
{
    int f = 1;

    for (int i = 2; i <= num; i++) 
    {
        f *= i;
    }
    return f;
}
int number = InputNum("Введите число: ");
int fact = Fact(number);
Console.WriteLine($"Факториал числе {number} равен {fact}");