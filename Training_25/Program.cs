// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program takes a string and returns the reversed string
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training_25;

internal class Program {
   static void Main () {
      Write ("Enter a string: ");
      WriteLine ($"Reversed string: {StringReverser (ReadLine ())}");
   }

   // Returns the reversed string for the entered string by preserving the order of casing and spaces
   static string StringReverser (string? input) {
      if (string.IsNullOrWhiteSpace (input)) return "";
      char[] result = new char[input.Length];
      int j = input.Length - 1;
      for (int i = 0; i < input.Length; i++) {
         char c = input[i];
         if (char.IsWhiteSpace (c)) result[i] = c;
         else {
            while (char.IsWhiteSpace (input[j])) j--;
            char ch = input[j--];
            result[i] = char.IsUpper (c) ? char.ToUpper (ch) : char.ToLower (ch);
         }
      }
      return new string (result);
   }
}
