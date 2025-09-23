// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T01 branch - Assignments Q1: NUMBER CONVERSION GAME
// ------------------------------------------------------------------------------------------------
using System.Text;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter a number");
      string? input = Console.ReadLine ();
      int num;
      while (string.IsNullOrWhiteSpace (input) || !int.TryParse (input, out num)) {
         Console.WriteLine ("Invalid input. Please enter a  number:");
         input = Console.ReadLine ();
      }
      Console.WriteLine ($"Input: {num}");
      int n = num;
      if (n == 0) {
         Console.WriteLine ("HEX: 0");
      } else {
         bool isNegative = n < 0;
         n = Math.Abs (n);
         StringBuilder sb = new ();
         while (n > 0) {
            int r = n % 16;
            n = n / 16;
            if (r < 10) {
               sb.Insert (0, r);
            } else {
               switch (r) {
                  case 10: sb.Insert (0, "A"); break;
                  case 11: sb.Insert (0, "B"); break;
                  case 12: sb.Insert (0, "C"); break;
                  case 13: sb.Insert (0, "D"); break;
                  case 14: sb.Insert (0, "E"); break;
                  case 15: sb.Insert (0, "F"); break;
               }
            }
         }
         string hexResult = isNegative ? "-" + sb.ToString () : sb.ToString ();
         Console.WriteLine ($"HEX: {hexResult}");
      }
      int b = Math.Abs (num);
      StringBuilder bn = new ();
      if (b == 0) {
         bn.Insert (0, 0);
      }
      while (b > 0) {
         int r = b % 2;
         b = b / 2;
         bn.Insert (0, r);
      }
      string binResult = (num < 0 ? "-" : "") + bn.ToString ();
      Console.WriteLine ($"Binary: {binResult}");
      Console.ReadLine ();
   }
}
