// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T03 branch. Assignment Q3:LCM and GCD Generator
// ------------------------------------------------------------------------------------------------
using static System.Console;
using static System.Math;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      int a = ReadValidInt ("Enter the first number: ");
      int b = ReadValidInt ("Enter the second number: ");
      WriteLine ($"GCD:{GCD (a, b)}");
      WriteLine ($"LCM:{LCM (a, b)}");
      ReadLine ();
   }

   static int ReadValidInt (string message) {
      WriteLine (message);
      int num;
      while (!int.TryParse (ReadLine (), out num))
         WriteLine ("Invalid input. Please enter a valid number: ");
      return num;
   }

   static int GCD (int a, int b) {
      a = Abs (a); b = Abs (b);
      while (b != 0) (a, b) = (b, a % b);
      return a;
   }

   static int LCM (int a, int b) => (a == 0 || b == 0 ? 0 : Abs ((a * b) / GCD (a, b)));

}