// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program takes a string and returns the reversed string
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training_25;

internal class Program {
   static void Main () {
      Write ("Enter a string: ");
      WriteLine ($"Reversed string: {StringReverser (ReadLine ())}");
   }
   static string StringReverser (string? input) {
      if (string.IsNullOrEmpty (input)) return string.Empty;
      var letters = new StringBuilder ();
      foreach (char c in input) if (!char.IsWhiteSpace (c)) letters.Append (c);
      var reversed = letters.ToString ().ToCharArray ();
      Array.Reverse (reversed);
      var sb = new StringBuilder ();
      int i = 0;
      foreach (char c in input)
         sb.Append (char.IsWhiteSpace (c) ? c : char.IsUpper (c) ?
            char.ToUpper (reversed[i++]) : char.ToLower (reversed[i++]));
      return sb.ToString ();
   }
}
