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
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100);
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
int[] arr = CreateArray(size);
FillArray(arr);
string answer = PrintArray(arr);
Console.WriteLine(answer);