// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to calculate the digital root of the given number
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      int num = ReadValidInt ("Enter a number to find its digital root: ");
      //Computes the digital root using modular arithmetic
      WriteLine ($"Digital root: {(num == 0 ? 0 : 1 + (num - 1) % 9)}");
   }

   /// <summary>Repeatedly prompts the user until a valid integer is entered.</summary>
   static int ReadValidInt (string prompt) {
      while (true) {
         Write (prompt);
         string? input = ReadLine ();
         if (int.TryParse (input, out int number ) && number > 0)
            return number;
         WriteLine ("Invalid input. Please enter a valid whole number.");
      }
   }
}