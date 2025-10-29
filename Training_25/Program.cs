// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on sorts and arranges even number first followed by odd number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main () {
      string? input;
      while (true) {
         Write ("Enter a string of numbers separated by comma: ");
         input = ReadLine ();
         if (string.IsNullOrEmpty (input) || input.Any (char.IsLetter)) {
            WriteLine ("Input cannot be empty. Please enter a valid string of numbers.");
            continue;
         }
         break;
      }
      SortEvenOdd (input);
   }

   // Function to sort even and odd numbers
   static int[] SortEvenOdd (string input) {
      string[] strArray = input.Split (',');
      int[] numArray = Array.ConvertAll (strArray, int.Parse);
      int[] evenArray = [.. numArray.Where (n => n % 2 == 0)];
      Array.Sort (evenArray);
      int[] oddArray = [.. numArray.Where (n => n % 2 != 0)];
      Array.Sort (oddArray);
      int[] sortedArray = [.. evenArray, .. oddArray];
      foreach (int num in sortedArray) {
         Write (num + " ");
      }
      return sortedArray;
   }
}
