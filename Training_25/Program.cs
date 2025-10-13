// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program prints the Nth Armstrong number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      int n = GetValidN (args);
      WriteLine (FindNthArmstrong (n));
   }

   // Gets a valid N from args or prompt
   static int GetValidN (string[] args) {
      if (args.Length > 0 && int.TryParse (args[0], out int n) && n >= 1 && n <= 25) return n;
      while (true) {
         Write ("Enter N (1 to 25): ");
         if (int.TryParse (ReadLine (), out n) && n >= 1 && n <= 25) return n;
         WriteLine ("Invalid input. Try again.");
      }
   }

   // Iterates through integers, counts Armstrong numbers, and returns the Nth one.
   static int FindNthArmstrong (int n) {
      int count = 0, num = 0;
      while (true) {
         if (IsArmstrong (num) && ++count == n)
            return num;
         num++;
      }
   }

   // Checks if the given number if Armstrong number (sum of its digits each raised to the power
   // of the total number of digits equals the number itself.)
   static bool IsArmstrong (int num) {
      int sum = 0, n = num;
      int digits = num.ToString ().Length;
      while (num > 0) {
         int rem;
         (rem, num) = (num % 10, num / 10);
         sum += (int)Math.Pow (rem, digits);
      }
      return sum == n;
   }
}
