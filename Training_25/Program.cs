// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Assignments 1: NUMBER CONVERSION GAME
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
using static System.Math;
namespace Training_25;

internal class Program {
   static void Main () {
      int num;
      while (true) {
         Write ("Enter a number: ");
         string? input = ReadLine ();
         if (!string.IsNullOrWhiteSpace (input) && int.TryParse (input, out num)) break;
         WriteLine ("Invalid input. Please enter a number.");
      }
      WriteLine ($"Input: {num}");
      int n = num;
      if (n == 0) WriteLine ("HEX: 0");
      else {
         bool isNegative = n < 0;
         n = Abs (n);
         StringBuilder sb = new ();
         while (n > 0) {
            int r = n % 16;
            n /= 16;            
            sb.Insert (0, r < 10 ? r : (char)('A' + r - 10));
         }
         string hexResult = $"{(isNegative ? "-" : "")}{sb}";
         WriteLine ($"HEX: {hexResult}");
      }
      int b = Abs (num);
      StringBuilder bn = new ();
      if (b == 0) bn.Insert (0, 0);
      while (b > 0) {
         int r = b % 2;
         b /= 2;
         bn.Insert (0, r);
      }
      WriteLine ($"Binary: {(num < 0 ? "-" : "")}{bn}");
   }
}