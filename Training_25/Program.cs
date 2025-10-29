// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program returns the alphabetic order corresponding to excel sheet for the given number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main () {
      Write ("Enter a number: ");
      int number = Convert.ToInt32 (ReadLine ());
      string result = GetExcelColumnName (number);
      WriteLine ($"{number} -> {result}");
   }

   // Function to convert a given number to its corresponding Excel column name.
   static string GetExcelColumnName (int number) {
      string columnName = string.Empty;
      while (number > 0) {
         int rem = (number - 1) % 26;
         columnName = Convert.ToChar (rem + 'A') + columnName;
         number = (number - 1) / 26;
      }
      return columnName;
   }
}
