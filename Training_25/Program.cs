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

   /// <summary>Repeadtedly prompts the user to enter a valid input.</summary>
   static int ReadValidInt (string message) {
      int num;
      while (true) {
         Write (message);
         string? input = ReadLine ();
         if (int.TryParse (input, out num) && num >= 0) break;
         WriteLine ("Invalid input. Please enter a valid number(whole numbers).");
      }
      return num;
   }
}