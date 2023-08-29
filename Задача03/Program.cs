/* Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */
int[] InputXY(string message)
{
    int[] arr = new int[2];
    Console.Write(message + "X: ");
    arr[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y: ");
    arr[1] = int.Parse(Console.ReadLine()!);
    return arr;
}
double Distance(int[] pointA, int[] pointB)
{
    int deltaX = pointA[0] - pointB[0];
    int deltaY = pointA[1] - pointB[1];
    double dis = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
    return dis;
}
int[] pA=InputXY("Введи координаты точки А ");
int[] pB=InputXY("Введи координаты точки B ");
double result=Distance(pA,pB);
result=Math.Round(result,2);
System.Console.WriteLine($"Расстояние {result}");
