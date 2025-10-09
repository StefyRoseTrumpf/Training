// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program reduces string of lowercase charecters by removing pair of adjacent matching letters.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using System.Text;

namespace Training_25;

internal class Program {
   static void Main () {
      string input = ReadValidString ("Enter a string: ");
      WriteLine (ReducedString (input));
   }

   // Continuously prompts until user enters a valid alphabetic string (a–z or A–Z)
   static string ReadValidString (string prompt) {
      while (true) {
         Write (prompt);
         string? input = ReadLine ()?.ToLower ();
         if (!string.IsNullOrWhiteSpace (input) && input.All (char.IsLetter))
            return input;
         WriteLine ("Invalid string. Please enter letters only (a-z or A-Z).");
      }
   }

   // Reduces the string by repeatedly removing adjacent pairs of identical characters.
   static string ReducedString (string input) {
      StringBuilder sb = new ();
      foreach (char c in input)
         sb = (sb.Length > 0 && sb[^1] == c) ? sb.Remove (sb.Length - 1, 1) : sb.Append (c);
      return sb.Length == 0 ? "Empty string" : sb.ToString ();
   }
}
