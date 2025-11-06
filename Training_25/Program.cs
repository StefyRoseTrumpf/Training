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
      GetInputs (out char[] arr, out char splChar, out char order);
      WriteLine ($"Result: {(order == 'd' ? SortAndSwap (arr, splChar, order) : SortAndSwap (arr, splChar))}");
   }

   // Gets valid inputs from the user.
   static void GetInputs (out char[] arr, out char splChar, out char order) {
      while (true) {
         Write ("Enter a string: ");
         arr = (ReadLine () ?? "").Trim ().ToLower ().ToCharArray ();
         Write ("Enter the special character: ");
         splChar = char.ToLower (ReadKey ().KeyChar);
         Write ("\nEnter sort order (D)escending / any other letter for ascending: ");
         order = char.ToLower (ReadKey ().KeyChar);
         WriteLine ();
         if (arr.Length == 0 || arr.Any (c => !char.IsLetter (c)) ||
            !char.IsLetter (splChar) || !char.IsLetter (order)) {
            WriteLine ("Invalid Input. Try again.");
            continue;
         }
         break;
      }
   }

   // Sorts the characters based on the given order and moves
   // all occurrences of the special character to the end.
   static string SortAndSwap (char[] arr, in char splChar, in char order = 'a') {
      List<char> normalChars = [], specialChars = [];
      foreach (char c in arr) (c == splChar ? specialChars : normalChars).Add (c);
      bool isDescending = order == 'd';
      normalChars.Sort ((x, y) => isDescending ? y.CompareTo (x) : x.CompareTo (y));
      arr = [.. normalChars, .. specialChars]; return string.Join (", ", arr);
   }
}