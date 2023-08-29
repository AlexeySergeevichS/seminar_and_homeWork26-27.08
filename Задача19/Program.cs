/* Палиндром. На вход пятизначное число.
14212 - нет
23432 - да
12821 - да
 */
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
bool CheckPalindrom(int number)
{
    if (number > 99999 || number < 10000) 
      {
        Console.WriteLine("Число не пятизначное");
        return false;
      }
      int firstDigit = number / 10000;
      int lastDigit = number % 10;
      int secondDigit = number / 1000 % 10;
      int prelastDigit = number % 100 / 10;
      if (firstDigit == lastDigit && secondDigit == prelastDigit)
        return true;
      else
        return false;
}
int num = InputNum("Введи пятизначное число: ");
bool cc = CheckPalindrom(num);
System.Console.WriteLine($"{cc}");