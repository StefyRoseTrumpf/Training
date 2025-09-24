// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T05 branch. Assignment Q5: Multiplication Table
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a number, to display it's multiplication table.");
      int num;
      while (!int.TryParse (ReadLine (), out num))
         WriteLine ("Invalid input. Please enter a valid whole number.");
      for (int i = 1; i <= 10; i++)
         WriteLine ($"{num} * {i,2} = {num * i,-3}");
      ReadLine ();
   }
}
