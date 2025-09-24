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
<<<<<<< Updated upstream
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
||||||| Stash base
      Console.WriteLine ("Enter a number");
      string? input = Console.ReadLine ();
      int num;
      while (string.IsNullOrWhiteSpace (input) || !int.TryParse (input, out num)) {
         Console.WriteLine ("Invalid input. Please enter a  number:");
         input = Console.ReadLine ();
      }
      Console.WriteLine ($"Input: {num}");
      int n = num;
      if (n == 0) Console.WriteLine ("HEX: 0");
      else {
         bool isNegative = n < 0;
         n = Math.Abs (n);
         StringBuilder sb = new ();
         while (n > 0) {
            int r = n % 16;
            n = n / 16;
            if (r < 10) 
               sb.Insert (0, r);
             else {
               switch (r) {
                  case 10: sb.Insert (0, "A"); break;
                  case 11: sb.Insert (0, "B"); break;
                  case 12: sb.Insert (0, "C"); break;
                  case 13: sb.Insert (0, "D"); break;
                  case 14: sb.Insert (0, "E"); break;
                  case 15: sb.Insert (0, "F"); break;
               }
            }
=======
      Console.WriteLine ("Enter a number");
      string? input = Console.ReadLine ();
      int num;
      while (string.IsNullOrWhiteSpace (input) || !int.TryParse (input, out num)) {
         Console.WriteLine ("Invalid input. Please enter a  number:");
         input = Console.ReadLine ();
      }
      Console.WriteLine ($"Input: {num}");
      int n = num;
      if (n == 0) Console.WriteLine ("HEX: 0");
      else {
         bool isNegative = n < 0;
         n = Math.Abs (n);
         StringBuilder sb = new ();
         while (n > 0) {
            int r = n % 16;
            n = n / 16;
            if (r < 10) 
               sb.Insert (0, r);
             else
               sb.Insert (0, (char)('A' + r - 10));
>>>>>>> Stashed changes
         }
         return a;
      }

      static int lcm (int a, int b) {
         return (a / gcd (a, b)) * b;
      }

      ReadLine ();
   }
}
