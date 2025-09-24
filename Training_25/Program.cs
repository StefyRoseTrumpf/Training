// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T06 branch. Assignment Q6: Digital Root.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a number, to find it's digital root:");
      long num;
      while (!long.TryParse (ReadLine (), out num))
         WriteLine ("Invalid input.Enter a valid number.");
      while (num >= 10) {
         long sum = 0;
         while (num > 0) {
            sum += num % 10;
            num /= 10;
         }
         num = sum;
      }
      WriteLine ($"Digital root:{num}");
      ReadKey ();
   }
}