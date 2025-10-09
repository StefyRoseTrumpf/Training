// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Converts the given number to hexadecimal and binary form
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
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
      WriteLine ($"HEX: {ConvertToBase (num, 16)}");
      WriteLine ($"Binary: {ConvertToBase (num, 2)}");
      WriteLine ("Press any key to exit..."); ReadKey ();
   }

   /// <summary>Converts an integer to a string representation in the specified base (2 for binary, 16 for hex, etc.)</summary>
   static string ConvertToBase (int n, int baseVal) {
      if (n == 0) return "0";
      bool neg = n < 0;
      n = Math.Abs (n);
      StringBuilder sb = new ();
      while (n > 0) {
         int rem = n % baseVal;
         n /= baseVal;
         sb.Append (rem < 10 ? (char)('0' + rem) : (char)('A' + rem - 10));
      }
      return $"{(neg ? "-" : "")}{new ([.. sb.ToString ().Reverse ()])}";
   }
}
