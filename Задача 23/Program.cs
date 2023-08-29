/*
 Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) 
и выводит таблицу кубов чисел от 1 до N
 (включительно) каждое на новой строке. 
 */
 int InputNum(string message)
 {
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
 }
 void ShowCube(int n)
 {
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }
 }
 int n = InputNum("Введи число: ");
 ShowCube(n);