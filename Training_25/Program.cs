// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T11 branch. Assignment Q11: Armstrong Number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a number to find it's an Armstrong number or not:");
      string? input = ReadLine ();
      int num;
      while (string.IsNullOrWhiteSpace (input) || !int.TryParse (input, out num) || num < 0) {
         WriteLine ("Invalid input. Please enter a valid non-negative number:");
         input = ReadLine ();
      }
      bool isArmstrong = IsArmstrongNumber (num);
      WriteLine (isArmstrong ? $"{num} is an Armstrong Number." : $"{num} is NOT an Armstrong Number.");
      ReadLine ();
   }
   static bool IsArmstrongNumber (int num) {
      int sum = 0, temp = num; int digits = num.ToString ().Length;
      while (temp > 0) {
         int remainder = temp % 10;
         sum += (int)Math.Pow (remainder, digits);
         temp /= 10;
      }
      return sum == num;
   }
}
