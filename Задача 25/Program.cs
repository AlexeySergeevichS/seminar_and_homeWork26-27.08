/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void AinB(int a, int b)
{
    int temp = 1;
    for (int i = 0; i < b; i++)
    {
        temp = temp * a;
    }
    Console.WriteLine($"Число {a} в степени {b} равно {temp}");
}
int a = InputNum("Введи число A: ");
int b = InputNum("Введи число B: ");
AinB(a, b);
