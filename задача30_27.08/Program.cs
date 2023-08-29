/* Задача 30: Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

 int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ArrOfNum(int size)
{
    int[] arr = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        arr[i]= new Random().Next(2); // случ число от 0 до 1
    }
    return  arr;
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        Console.Write(" ");
    }
}
int size=InputNum("Введи длину ");
int[] arr=ArrOfNum(size);
PrintArr(arr); 


 /* // Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ArrayOfNumbers(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
} 

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int size = InputNum("Введите размер массива: ");
int[] result = ArrayOfNumbers(size);
PrintArray(result); 
 */