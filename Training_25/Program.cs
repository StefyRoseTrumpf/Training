// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      long[] armstrongsNums = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474, 54748, 92727, 93084,
                                548834, 1741725, 4210818, 9800817, 9926315, 24678050, 24678051, 88593477, 146511208, 472335975,
                                534494836, 912985153, 4679307774, 32164049650, 32164049651 ];
      WriteLine ("Enter a number to find the Nth Armstrong Number:");
      if (int.TryParse (ReadLine (), out int n) && n > 0 && n <= armstrongsNums.Length) {
         WriteLine ($"The {GetOrdinal (n)} Armstrong number is: {armstrongsNums[n - 1]}");
         WriteLine ($"The {n}th Armstrong number is: {armstrongsNums[n - 1]}");
      } else {
         WriteLine ($"Only the first {armstrongsNums.Length} Armstrong numbers are supported.");
      }
      ReadLine ();
   }
   static string GetOrdinal (int n) {
      int mod100 = n % 100;
      if (mod100 == 11 || mod100 == 12 || mod100 == 13)
         return n + "th";
      return (n % 10) switch {
         1 => n + "st",
         2 => n + "nd",
         3 => n + "rd",
         _ => n + "th",
      };
   }
}
