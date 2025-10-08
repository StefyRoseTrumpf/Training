// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program calculates the LCM and GCD of the given input numbers.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using static System.Math;
namespace Training_25;

internal class Program {
   static void Main () {
      int a = ReadValidInt ("Enter the first number: ");
      int b = ReadValidInt ("Enter the second number: ");
      WriteLine ($"LCM:{LCM (a, b)}");
      WriteLine ($"GCD:{GCD (a, b)}");
      WriteLine ("Press any key to exit..."); ReadKey ();
   }

   /// <summary>Prompts the user until a valid integer is entered.</summary>
   static int ReadValidInt (string message) {
      int num;
      while (true) {
         Write (message);
         string? input = ReadLine ();
         if (int.TryParse (input, out num)) break;
         WriteLine ("Invalid input. Please enter a valid number: ");
      }
      return num;
   }

   /// <summary>Calculates the Greatest Common Divisor (GCD) of two integers using the Euclidean algorithm.</summary>
   static int GCD (int a, int b) {
      a = Abs (a); b = Abs (b);
      while (b != 0) (a, b) = (b, a % b);
      return a;
   }

   /// <summary>Calculates the Least Common Multiple (LCM) of two integers using their GCD.</summary>
   static int LCM (int a, int b) => (a == 0 || b == 0 ? 0 : Abs ((a * b) / GCD (a, b)));
}