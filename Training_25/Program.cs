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
      int num = GetValidInput (args);
      Write (FindNthArmstrong (num));
   }

   // Gets a valid number from args or prompt
   static int GetValidInput (string[] args) {
      if (args.Length > 0 && int.TryParse (args[0], out int num) && num >= 1 && num <= 25)
         return num;
      WriteLine ("Invalid input.");
      Environment.Exit (0);
      return 0;
   }

   // Iterates through integers, counts Armstrong numbers, and returns the Nth one.
   static int FindNthArmstrong (int n) {
      int count = 0, num = 0;
      while (true) {
         if (IsArmstrong (num) && ++count == n) return num;
         num++;
      }
   }

   // Checks if the given number is Armstrong number (sum of its digits each raised to the power
   // of the total number of digits equals the number itself.)
   static bool IsArmstrong (int num) {
      if (num < 10) return true;
      int sum = 0, orgNum = num, digits = num.ToString ().Length;
      while (num > 0) {
         (int rem, num) = (num % 10, num / 10);
         sum += (int)Math.Pow (rem, digits);
      }
      return sum == orgNum;
   }
}