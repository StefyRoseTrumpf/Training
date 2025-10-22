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
      while (true) {
         int num = ReadValidInt ();
         WriteLine ($"{num} is {(IsArmstrongNumber (num) ? "" : "NOT ")}an Armstrong Number." +
            $"\nDo you want to check another number? " +
            $"(enter 'Y' to continue or any other key to exit the program): ");
         if (ReadKey ().Key != ConsoleKey.Y) {
            WriteLine ("\nExiting the program.");
            break;
         }
      }
   }

   // Continuously prompts the user to enter a valid positive number.
   static int ReadValidInt () {
      while (true) {
         Write ("\nEnter a number to check if it's an Armstrong number: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0) return num;
         WriteLine ("Invalid input. Please enter a valid whole number.");
      }
   }

   // Checks if the given number is an Armstrong number.(sum of its digits each raised to the power
   // of the total number of digits equals the number itself.)
   static bool IsArmstrongNumber (int num) {
      if (num < 10) return true;
      int sum = 0, orgNum = num, digits = num.ToString ().Length;
      while (num > 0) {
         (int rem, num) = (num % 10, num / 10);
         sum += (int)Math.Pow (rem, digits);
      }
      return sum == orgNum;
   }
}
