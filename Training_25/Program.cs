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
      GetAllInputs (out char[] arr, out char special, out string ord);
      WriteLine ($"Result: {SortAndSwap (ref arr, special, ord)}");
   }

   static void GetAllInputs (out char[] arr, out char special, out string ord) {
      arr = [];
      special = '\0';
      ord = "ascending";
      bool gotArray = false, gotSpecial = false, gotOrder = false;
      while (!(gotArray && gotSpecial && gotOrder)) {
         //Reads and validates an array of characters from user input.
         if (!gotArray) {
            Write ("Enter characters separated by commas (e.g., a,b,c,a): ");
            string? input = ReadLine ()?.Trim ();
            if (!string.IsNullOrWhiteSpace (input)) {
               var parts = input.Split (',').Select (p => p.Trim ()).ToArray ();
               if (!parts.Any (p => p.Length != 1 || !char.IsLetter (p[0]))) {
                  arr = [.. parts.Select (p => char.ToLower (p[0]))];
                  gotArray = true;
                  continue;
               }
            }
            WriteLine ("Invalid array. Use only letters separated by commas."); continue;
         }
         //Reads and validates a single special character.
         if (!gotSpecial) {
            Write ("Enter the special character: ");
            char input = char.ToLower (ReadKey ().KeyChar);
            if (char.IsLetter (input)) {
               special = input;
               gotSpecial = true;
               continue;
            }
            WriteLine ("Invalid input. Enter exactly ONE letter."); continue;
         }
         // Reads and validates the sort order. Defaults to "ascending".
         if (!gotOrder) {
            Write ("\nEnter sort order (ascending/descending, default ascending): ");
            string? input = ReadLine ()?.Trim ().ToLower ();
            if (string.IsNullOrWhiteSpace (input) || input == "ascending" || input == "descending") {
               ord = string.IsNullOrWhiteSpace (input) ? "ascending" : input;
               gotOrder = true;
               continue;
            }
            WriteLine ("Invalid input. Enter 'ascending' or 'descending'.");
         }
      }
   }

   // Sorts the characters based on the given order and moves
   // all occurrences of the special character to the end.
   static string SortAndSwap (ref char[] arr, char special, string order = "ascending") {
      var normalChars = new List<char> ();
      var specialChars = new List<char> ();
      foreach (char c in arr) (c == special ? specialChars : normalChars).Add (c);
      normalChars.Sort ((x, y) => order == "descending" ? y.CompareTo (x) : x.CompareTo (y));
      arr = [.. normalChars, .. specialChars]; return string.Join (", ", arr);
   }
}
