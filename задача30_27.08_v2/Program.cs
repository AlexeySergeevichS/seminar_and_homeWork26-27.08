// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] ints)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(2);
    }
}
string PrintArray(int[] ints)
{
    string res = ""; // res=String.Empty;
    for (int i = 0; i < ints.Length; i++)
    {
        res += $"{ints[i]} ";
    }
    return res;
}
int size = InputNum("Введите размер масива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
string answer = PrintArray(myArray);
Console.WriteLine(answer);


// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// void FillArray(int[] ints)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < ints.Length; i++)
//         ints[i] = rnd.Next(2);
// }

// string PrintArray(int[] ints)
// {
//     string res = ""; // res = String.Empty;
//     for (int i = 0; i < ints.Length; i++)
//         res += $"{ints[i]} ";
//     return res;
// }

// int size = InputNum("Введите размер массива: ");
// int[] myArray = CreateArray(size);
// FillArray(myArray);
// string answer = PrintArray(myArray);
// System.Console.WriteLine(answer);

// void Func(int num) // параметр
// {
//     num = num / 2;
//     System.Console.WriteLine("num = " + num);
// }


// int a = 5;
// System.Console.WriteLine(a);
// Func(a); // аргумент
// System.Console.WriteLine(a);

//int[] array1 = {1, 2, 3, 4, 5};
// int[] array2 = array1;
// Console.WriteLine(String.Join(" ", array1));
// Console.WriteLine(String.Join(" ", array2));
// System.Console.WriteLine("______________________");
// array1[2] = 10;
// Console.WriteLine(String.Join(" ", array1));
// Console.WriteLine(String.Join(" ", array2));
// System.Console.WriteLine("______________________");
// array2[4] = 15;
// Console.WriteLine(String.Join(" ", array1));
// Console.WriteLine(String.Join(" ", array2));
// int[] array2 = new int[array1.Length];
// for (int i = 0; i < array1.Length; i++)
// {
//     array2[i] = array1[i];
// }
// Console.WriteLine(String.Join(" ", array1));
// Console.WriteLine(String.Join(" ", array2));
// System.Console.WriteLine("______________________");
// array1[2] = 10;
// Console.WriteLine(String.Join(" ", array1));
// Console.WriteLine(String.Join(" ", array2));
// System.Console.WriteLine("______________________");