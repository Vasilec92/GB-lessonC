
/* 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным */

bool IsWeekend(int dayNumber)
{
   return dayNumber == 6 || dayNumber == 7;
}


Console.Write("Введите номер дня недели (1-7): ");
int dayNumber = int.Parse(Console.ReadLine());

if (IsWeekend(dayNumber))
{
   Console.WriteLine("Этот день является выходным.");
}
else
{
   Console.WriteLine("Этот день не является выходным.");
}