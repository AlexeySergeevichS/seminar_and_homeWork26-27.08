/* 
принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/

int[] InputPoint(string message)
{
    int[] coord = new int[3];
    for (int i = 0; i < coord.Length; i++)
    {
        Console.Write($"{message}{i+1}= ");
        coord[i] = int.Parse(Console.ReadLine()!);
    }
    return coord;
}
double LenghtP(int[] pA, int[] pB)
{
    double dist=0;
    for (int i = 0; i < pA.Length; i++)
    {
        dist = dist + Math.Pow(pA[i] - pB[i], 2);
    }
    dist = Math.Round(Math.Sqrt(dist),2);
    return  dist;
    //Console.WriteLine($"{dist}");
}
int[] pA = InputPoint("Кординаты точки A a");
int[] pB = InputPoint("Кординаты точки B b");
Console.WriteLine($"{LenghtP(pA, pB)}");
