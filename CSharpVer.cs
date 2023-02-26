using System;

namespace Homework
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.Title = "Fuck and I mean fuck";
      Console.WriteLine("SnailPi: Welcome to CUM LAND. Tickets cost $69420. Pay up bitch.\nHow much cash will you give the bitch?");
      int int32 = Convert.ToInt32(Console.ReadLine());
      if (int32 < 69420)
      {
        Console.WriteLine("SnailPi: OHHHHH BITCH YOU THINK YOU CAN SCAM ME?");
        Console.ReadLine();
        Console.WriteLine("*SnailPi pulls out a glock*");
        Console.ReadLine();
        Console.WriteLine("*SnailPi aims it at you and shoots you*");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You DIED");
      }
      else if (int32 == 69420)
      {
        Console.WriteLine("SnailPi: Thanks for the money bitch");
        Console.ReadLine();
        Console.WriteLine("*SnailPi pulls out a glock*");
        Console.ReadLine();
        Console.WriteLine("*SnailPi aims it at you and shoots you*");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You DIED");
      }
      else
      {
        int num = int32 - 69420;
        Console.WriteLine("SnailPi: MMMMMMMMM\nSnailPi: Thanks for the " + num.ToString() + " dollar tip.");
        Console.ReadLine();
        Console.WriteLine("*SnailPi pulls out a glock*");
        Console.ReadLine();
        Console.WriteLine("*SnailPi aims it at you and shoots you " + num.ToString() + " times*");
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You DIED");
      }
      Console.ReadKey();
    }
  }
}
