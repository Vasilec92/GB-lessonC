/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int GetThirdDigit(int num)
{

   if (num < 100)
   {
      return -1;
   }

   if (num > 999)
   {
      return (num / 100) % 10;

   }

   int thirdDigit = num % 10;
   return thirdDigit;
}





Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int thirdDigit = GetThirdDigit(number);

if (thirdDigit != -1)
{
   Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
else
{
   Console.WriteLine("Третьей цифры нет");
}


