// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program returns the smallest number of steps taken to transform the number into identical digits
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main () {
      while (true) {
         Write ("Enter a number: ");
         if (!int.TryParse (ReadLine (), out int num)) {
            WriteLine ("Invalid input. Please enter a valid number."); continue;
         }
         WriteLine ($"{num} -> {MinSteps (num)} Steps");
         Write ("Check another number? (enter 'y' to continue or any other key to exit): ");
         if (ReadKey ().Key != ConsoleKey.Y) {
            WriteLine ("\nExiting the program.");
            break;
         }
         WriteLine ();
      }
   }

   // Returns the minimum number of steps needed to convert a number into identical digits
   static int MinSteps (int number) {
      string digits = Math.Abs (number).ToString ();
      int minSteps = 0;
      for (int target = 0; target <= 9; target++) {
         int steps = 0;
         foreach (var c in digits) steps += Math.Abs (c - '0' - target);
         if (target == 0 || steps < minSteps) minSteps = steps;
      }
      return minSteps;
   }
}
