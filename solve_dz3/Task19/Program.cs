// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}
int N = Prompt("ВВедите пятизначное число: ");
int part1, part2;
part1 = (int)N / 1000;
part2 = (N % 10) * 10;
N = N / 10;
part2 = part2 + N % 10;
if (part1 == part2)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Нет");
