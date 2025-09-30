// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T11.1 branch. Assignment Q11.1: Nth Armstrong Number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      int n;
      while (true) {
         WriteLine ("Enter N to find the Nth Armstrong number (1 to 25): ");
         if (int.TryParse (ReadLine (), out n) && n >= 1 && n <= 25)
            break;

         WriteLine ("Invalid input. Please enter a positive integer between 1 and 25.");
      }
      long result = FindNthArmstrong (n);
      WriteLine ($"The {GetOrdinal (n)} Armstrong number is: {result}");
      ReadLine ();
   }

   static long FindNthArmstrong (int n) {
      int count = 0;
      long num = 0;
      while (true) {
         if (IsArmstrong (num)) {
            count++;
            if (count == n) return num;
         }
         num++;
      }
   }

   static bool IsArmstrong (long num) {
      long sum = 0, temp = num;
      int digits = num.ToString ().Length;

      while (temp > 0) {
         long digit = temp % 10;
         sum += (long)Math.Pow (digit, digits);
         temp /= 10;
      }

      return sum == num;
   }

   static string GetOrdinal (int n) {
      int mod100 = n % 100;
      if (mod100 == 11 || mod100 == 12 || mod100 == 13) return $"{n}th";

      return (n % 10) switch {
         1 => $"{n}st",
         2 => $"{n}nd",
         3 => $"{n}rd",
         _ => $"{n}th"
      };
   }
}
