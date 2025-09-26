// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T10 branch. Assignment Q10: Reverse the String
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a string:");
      string? input = ReadLine ();
      string sb = StringReverser (input);
      WriteLine ($"Input string: {input}\nReversed string: {sb}");

      static string StringReverser (string? input) {
         if (string.IsNullOrEmpty (input)) return string.Empty;
         var letters = new StringBuilder ();
         foreach (char c in input) {
            if (c != ' ') letters.Append (c);
         }
         char[] reversedLetters = letters.ToString ().ToCharArray ();
         Array.Reverse (reversedLetters);
         var sb = new StringBuilder ();
         int letterIndex = 0;
         foreach (char c in input) {
            if (c == ' ') sb.Append (' ');
            else {
               char ch = reversedLetters[letterIndex++];
               sb.Append (char.IsUpper (c) ? char.ToUpper (ch) : char.ToLower (ch));
            }
         }
         return sb.ToString ();
      }
      ReadLine ();
   }
}
