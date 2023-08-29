/* Задача17 Напишите прог котор проинимает на вход коорд точки (x,y),
причем X не 0 и Y не 0  и выдает номер четверти плоскости, в которой находится эта точка.  */
/* int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
 */
int[] GetCoor(string message)
{
    int[] coordinates = new int[2];
    Console.Write(message + "X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    return coordinates;
}


// string GetQuater(int axisX, int aixsY)
// {
//     string answer = "";
//     if (axisX > 0 && aixsY > 0)
//         answer = "I четверть";
//     else if (axisX < 0 && aixsY > 0)
//         answer = "II четверть";
//     else if (axisX < 0 && aixsY < 0)
//         answer = "III четверть";
//     else if (axisX > 0 && aixsY < 0)
//         answer = "IV четверть";
//     else
//         answer = "Точка на границе четвертей";
//     return answer;
// }

/* void GetQuater(int axisX, int aixsY)
{
    
    if (axisX > 0 && aixsY > 0)
        System.Console.WriteLine("I четверть");
    else if (axisX < 0 && aixsY > 0)
        System.Console.WriteLine("II четверть");
    else if (axisX < 0 && aixsY < 0)
        System.Console.WriteLine("III четверть");
    else if (axisX > 0 && aixsY < 0)
        System.Console.WriteLine("IV четверть");
    else
        System.Console.WriteLine("Точка на границе четвертей");
    
} */

void GetQuater(int[] coor)
{

    if (coor[0] > 0 && coor[1] > 0)
        System.Console.WriteLine("I четверть");
    else if (coor[0] < 0 && coor[1] > 0)
        System.Console.WriteLine("II четверть");
    else if (coor[0] < 0 && coor[1] < 0)
        System.Console.WriteLine("III четверть");
    else if (coor[0] > 0 && coor[1] < 0)
        System.Console.WriteLine("IV четверть");
    else
        System.Console.WriteLine("Точка на границе четвертей");

}

// int coorX = InputNum("Введи X: ");
// int coorY = InputNum("Введи Y: ");
int[] coors = GetCoor("Введи ");
GetQuater(coors);
// string result = GetQuater(coorX, coorY);
// System.Console.WriteLine(result);
//GetQuater(coorX, coorY);
