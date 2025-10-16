// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program sorts and swaps the array with the special character in ascending or descending order.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      GetAllInputs (out char[] arr, out char special, out string ord);
      WriteLine ($"Result: {SortAndSwap (ref arr, special, ord)}");
   }

   static void GetAllInputs (out char[] arr, out char special, out string ord) {
      //Reads and validates an array of characters from user input.
      while (true) {
         Write ("Enter characters separated by commas (e.g., a,b,c,a): ");
         string? input = ReadLine ()?.Trim ();
         if (!string.IsNullOrWhiteSpace (input)) {
            var parts = input.Split (',').Select (p => p.Trim ()).ToArray ();
            if (parts.All (p => p.Length == 1 && char.IsLetter (p[0]))) {
               arr = [.. parts.Select (p => char.ToLower (p[0]))]; break;
            }
         }
         WriteLine ("Invalid array. Use only letters separated by commas.");
      }
      //Reads and validates a single special character.
      while (true) {
         Write ("Enter the special character: ");
         string? input = ReadLine ()?.Trim ();
         if (!string.IsNullOrEmpty (input) && input.Length == 1 && char.IsLetter (input[0])) {
            special = char.ToLower (input[0]); break;
         }
         WriteLine ("Invalid input. Enter exactly ONE letter.");
      }
      // Reads and validates the sort order. Defaults to "ascending".
      while (true) {
         Write ("Enter sort order (ascending/descending, default ascending): ");
         string? input = ReadLine ()?.Trim ().ToLower ();
         if (string.IsNullOrWhiteSpace (input) || input == "ascending" || input == "descending") {
            ord = string.IsNullOrWhiteSpace (input) ? "ascending" : input; break;
         }
         WriteLine ("Invalid input. Enter 'ascending' or 'descending'.");
      }
   }
   // Sorts the characters based on the given order and moves
   // all occurrences of the special character to the end.
   static string SortAndSwap (ref char[] arr, char special, string order = "ascending") {
      if (arr == null || arr.Length == 0)
         throw new ArgumentException ("Array cannot be null or empty.");
      var normalChars = arr.Where (c => c != special).ToList ();
      var specialChars = arr.Where (c => c == special).ToList ();
      normalChars.Sort ((x, y) =>
         order == "descending" ? y.CompareTo (x) : x.CompareTo (y)
      );
      arr = [.. normalChars, .. specialChars]; return string.Join (", ", arr);
   }
}
