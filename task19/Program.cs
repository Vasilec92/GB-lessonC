// See https://aka.ms/new-console-template for more information
/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

bool IsPalindrome(int num)
{
   string numString = num.ToString();

   for (int i = 0; i < numString.Length / 2; i++)
   {
      if (numString[i] != numString[numString.Length - 1 - i])
      {
         Console.WriteLine("Нет, это число не является палиндромом.");
         return false;
      }
   }
   Console.WriteLine("Да, это число является палиндромом.");
   return true;
}

IsPalindrome(14212);
IsPalindrome(12821);
IsPalindrome(23432);

