// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T03 branch. Assignment Q3:LCM and GCD Generator
// ------------------------------------------------------------------------------------------------
namespace Training_25;
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the first number:");
      string? input1 = Console.ReadLine ();
      int a;
      while (!int.TryParse (input1, out a)) {
         Console.WriteLine ("Invalid input.Please enter a valid number.");
         input1 = Console.ReadLine ();
      }
      Console.WriteLine ("Enter the second number:");
      string? input2 = Console.ReadLine ();
      int b;
      while (!int.TryParse (input2, out b)) {
         Console.WriteLine ("Invalid input.Please enter a valid number.");
         input2 = Console.ReadLine ();
      }
      Console.WriteLine ($"GCD:{gcd (a, b)}");
      Console.WriteLine ($"LCM:{lcm (a, b)}");
      static int gcd (int a, int b) {
         while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
         }
         return a;
      }
      static int lcm (int a, int b) {
         return (a / gcd (a, b)) * b;
      }
      Console.ReadLine ();
   }
}
