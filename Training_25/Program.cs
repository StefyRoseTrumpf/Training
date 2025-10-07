// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Assignment 5: Multiplication Table
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      for (int num = 1; num <= 10; num++) {
         for (int i = 1; i <= 10; i++)
            WriteLine ($"{num} * {i,2} = {num * i,-3}");
         WriteLine ();
      }
   }
}