// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program returns whether the entered number is Armstrong number or not.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main () {
      int num = ReadValidInt ("Enter a number to check if it's an Armstrong number: ");
      WriteLine ($"{num} is {(IsArmstrongNumber (num) ? "" : "NOT ")}an Armstrong Number.");
   }

   // Continuously prompts the user to enter a valid positive number.
   static int ReadValidInt (string prompt) {
      while (true) {
         Write (prompt);
         string? input = ReadLine ();
         if (int.TryParse (input, out int num) && num >= 0)
            return num;
         WriteLine ("Invalid input. Please enter a valid whole number");
      }
   }

   // Checks if the given number if Armstrong number (sum of its digits each raised to the power
   // of the total number of digits equals the number itself.)
   static bool IsArmstrongNumber (int num) {
      int sum = 0, n = num; int digits = num.ToString ().Length;
      while (num > 0) {
         int rem;
         (rem, num) = (num % 10, num / 10);
         sum += (int)Math.Pow (rem, digits);
      }
      return sum == n;
   }
}
