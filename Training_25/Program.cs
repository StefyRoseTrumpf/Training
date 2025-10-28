// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program sorts the array in ascending or descending order and moves the special character to end.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      GetInputs (out char[] arr, out char special, out char ord);
      WriteLine ($"Result: {SortAndSwap (arr, special, ord)}");
   }

   static void GetInputs (out char[] arr, out char special, out char ord) {
      while (true) {
         Write ("Enter a string: ");
         arr = (ReadLine () ?? "").Trim ().ToLower ().ToCharArray();
         Write ("Enter the special character: ");
         special = char.ToLower (ReadKey ().KeyChar);
         Write ("\nEnter sort order ('d' for descending / any other key for ascending): ");
         ord = char.ToLower (ReadKey ().KeyChar);
         WriteLine ();
         if (arr.Length == 0 || arr.Any (c => !char.IsLetter (c))
                                             || !char.IsLetter (special)
                                             || !char.IsLetter (ord)) {
            WriteLine ("Invalid Input. Try again.");
            continue;
         }
         break;
      }
   }

   // Sorts the characters based on the given order and moves
   // all occurrences of the special character to the end.
   static string SortAndSwap (char[] arr, in char special, in char order = 'a') {
      List<char> normalChars = [], specialChars = [];
      foreach (char c in arr) (c == special ? specialChars : normalChars).Add (c);
      bool isDescending = order == 'd';
      normalChars.Sort ((x, y) => isDescending ? y.CompareTo (x) : x.CompareTo (y));
      arr = [.. normalChars, .. specialChars]; return string.Join (", ", arr);
   }
}
