/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void SumDigits(int num)
{
    int sum = num % 10; 
    for (int i = 0; num != 0; i++)
    {
        num /= 10; // num=num/10
        sum+= num % 10; //sum=sum+num%10
    }
    System.Console.WriteLine(sum);
}
int n = InputNum("Введи число: ");
SumDigits(n);