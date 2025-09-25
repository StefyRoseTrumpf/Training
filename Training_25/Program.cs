// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T07 branch. Assignment Q7: Pascal's Triangle.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter the number of rows for the Pascal's triangle:");
      int rows;
      while (true) {
         if (int.TryParse (ReadLine (), out rows) && rows >= 0) break;
         WriteLine ("Invalid input. Please enter a valid number (whole numbers).");
      }
      for (int i = 0; i < rows; i++) {
         Write (new string (' ', (rows - i) * 2));
         int value = 1;
         for (int j = 0; j <= i; j++) {
            Write ($"{value,4}");
            value = value * (i - j) / (j + 1);
         }
         WriteLine ();
      }
      ReadLine ();
   }
}
