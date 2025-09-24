// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T03 branch. Assignment Q3:LCM and GCD Generator
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter the first number:");
      int a;
      while (!int.TryParse (ReadLine (), out a))
         WriteLine ("Invalid input.Please enter a valid number.");
      WriteLine ("Enter the second number:");
      int b;
      while (!int.TryParse (ReadLine (), out b))
         WriteLine ("Invalid input.Please enter a valid number.");
      WriteLine ($"GCD:{gcd (a, b)}");
      WriteLine ($"LCM:{lcm (a, b)}");

      static int gcd (int a, int b) {
         while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
         }
         return a;
      }

      static int lcm (int a, int b) {
         return (a / gcd (a, b)) * b;
      }

      ReadLine ();
   }
}
