// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Converts the given number to hexadecimal and binary form
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
      WriteLine ($"HEX: {ConvertToBase (num, 16)}");
      WriteLine ($"Binary: {ConvertToBase (num, 2)}");
      WriteLine ("Press any key to exit..."); ReadKey ();
   }

   /// <summary>Converts an integer to a string representation in the specified base (2 for binary, 16 for hex, etc.)</summary>
   static string ConvertToBase (int n, int baseValue) {
      if (n == 0) return "0";
      bool isNegative = n < 0;
      n = Abs (n);
      StringBuilder sb = new ();
      while (n > 0) {
         int remainder = n % baseValue;
         n /= baseValue;
         char c = (char)(remainder - 10 + 'A');
         sb.Append (remainder < 10 ? remainder : (c.ToString ()));
      }
      return $"{(isNegative ? "-" : "")}{new ([.. sb.ToString ().Reverse ()])}";
   }
}
