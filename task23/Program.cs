/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


void getCube(int N)
{
   Console.WriteLine("Таблица кубов чисел:" + N);

   for (int i = 1; i <= N; i++)
   {
      int cube = i * i * i;
      Console.Write(cube);

      if (i < N)
      {
         Console.Write(", ");
      }
   }
   Console.WriteLine();
}

getCube(3);
getCube(5);