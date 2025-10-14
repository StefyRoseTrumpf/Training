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

   // Returns the reversed string for the entered string by preserving the order of casing and spaces
   static string StringReverser (string? input) {
      if (string.IsNullOrEmpty (input)) return string.Empty;
      var reversed = input.Where (c => !char.IsWhiteSpace (c)).Reverse ().ToArray ();
      var sb = new StringBuilder ();
      int i = 0;
      foreach (char c in input)
         sb.Append (char.IsWhiteSpace (c) ? c : char.IsUpper (c) ?
            char.ToUpper (reversed[i++]) : char.ToLower (reversed[i++]));
      return sb.ToString ();
   }
}
