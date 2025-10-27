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
      int num;
      while (true) {
         Write ("Enter a number: ");
         if (int.TryParse (ReadLine () ?? "0", out num)) break;
         WriteLine ("Invalid input. Please enter a valid number.");
      }
      WriteLine ($"{num} -> {MinSteps (num)} Steps");
   }

   //Returns the minimum number of steps needed to convert a number into identical digits
   static int MinSteps (int number) {
      string digits = Math.Abs (number).ToString ();
      int minSteps = -1;
      for (int target = 0; target <= 9; target++) {
         int total = 0;
         foreach (char c in digits) {
            total += Math.Abs ((c - '0') - target);
         }
         if (minSteps == -1 || total < minSteps)
            minSteps = total;
      }
      return minSteps;
   }
}
