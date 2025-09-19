// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T01 branch - Assignments Q1
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training_25;

internal class Program {
   static void Main (string[] args) {

      Console.WriteLine ("Enter a number");
      string input = Console.ReadLine ();
      int num = Convert.ToInt32 (input);

      Console.WriteLine ($"Input:{num}");

      if (num <= 9 && num >= 0) {
         Console.WriteLine ($"HEX:{num}");
      } else if (num <= 16 && num > 9) {
         switch (num) {
            case 10: Console.WriteLine ("HEX:A"); break;
            case 11: Console.WriteLine ("HEX:B"); break;
            case 12: Console.WriteLine ("HEX:C"); break;
            case 13: Console.WriteLine ("HEX:D"); break;
            case 14: Console.WriteLine ("HEX:E"); break;
            case 15: Console.WriteLine ("HEX:F"); break;
         }
      } else {
         int n = num;
         StringBuilder sb = new StringBuilder ();

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
         Console.WriteLine ($"HEX:{sb}");
         // Console.WriteLine($"HEX:{(q * 10) + r}");



      }
      int b = num;
      StringBuilder bn = new StringBuilder ();
      while (b > 0) {
         int r = b % 2;
         b = b / 2;

         bn.Insert (0, r);

      }
      Console.WriteLine ($"Binary:{bn}");




      Console.ReadLine ();


   }
}
