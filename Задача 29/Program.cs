/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 
*/
int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] arr,int a,int b)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(a,b+1);
       // Console.Write(arr[i]);
       // Console.Write(" ");
    }
}
string PrintArray(int[] arr)
{
    string str = "[";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        str += $"{arr[i]},";
    }
    str += $"{arr[arr.Length - 1]}]";
    return str;
}
int size = InputNum("Введи кол-во элементов массива: ");
int a = InputNum("Введи нижнюю границу элементов массива: ");
int b = InputNum("Введи верхнюю границу элементов массива: ");

int[] arr = CreateArray(size);
FillArray(arr,a,b);
string answer = PrintArray(arr);
Console.WriteLine(answer);