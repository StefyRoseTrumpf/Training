// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program prints the Pascal's triangle for the given number of rows.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training_25;

internal class Program {
   static void Main () {
      int rows = ReadValidInt ("Enter the number of rows for the Pascal's triangle: ");
      for (int i = 0; i < rows; i++) {
         Write (new string (' ', (rows - i) * 2));
         int value = 1;
         for (int j = 0; j <= i; j++) {
            Write ($"{value,4}");
            value = value * (i - j) / (j + 1);
         }
         WriteLine ();
      }
   }

   // Repeadtedly prompts the user to enter a valid input.
   static int ReadValidInt (string message) {
      int num;
      while (true) {
         Write (message);
         if (int.TryParse (ReadLine (), out num) && num > 0 && num < 14) break;
         WriteLine ("Invalid input. Please enter a valid number(between 1 to 13).");
      }
      return num;
   }
}
