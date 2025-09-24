// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T01 branch - Assignments Q1: NUMBER CONVERSION GAME
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
using static System.Math;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a number");
      string? input = ReadLine ();
      int num;
      while (string.IsNullOrWhiteSpace (input) || !int.TryParse (input, out num)) {
         WriteLine ("Invalid input. Please enter a  number:");
         input = ReadLine ();
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
            if (r < 10) sb.Insert (0, r);
            else
               sb.Insert (0, (char)('A' + r - 10));
         }
         string hexResult = isNegative ? "-" + sb.ToString () : sb.ToString ();
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
      string binResult = (num < 0 ? "-" : "") + bn.ToString ();
      WriteLine ($"Binary: {binResult}");
      ReadLine ();
   }
}
