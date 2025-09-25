// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T09 branch. Assignment Q9: Reduced String.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using System.Text;
namespace Training_25;
internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a string:");
      string? input = ReadLine ()?.ToLower ();
      while (string.IsNullOrEmpty (input) || input.Any (char.IsDigit)) {
         Console.WriteLine ("Invalid string. Enter a valid string.");
         input = ReadLine ()?.ToLower ();
      }
      WriteLine (ReducedString (input));

      static string ReducedString (string input) {
         StringBuilder sb = new ();
         foreach (char c in input) {
            if (sb.Length > 0 && sb[sb.Length - 1] == c) sb.Remove (sb.Length - 1, 1);
            else sb.Append (c);
         }
         return sb.Length == 0 ? "Empty string" : sb.ToString ();
      }
      ReadLine ();
   }
}
