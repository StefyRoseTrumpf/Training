// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program returns the most occurring letter from the given string.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      var (winner, count) = CountVotes (ReadValidString ());
      WriteLine ($"Winner: {winner} and Votes: {count}");
   }

   // Reads only alphabetic + whitespace, rejects empty or invalid strings
   static string ReadValidString () {
      while (true) {
         Write ("Enter a string: ");
         string input = ReadLine ()?.Trim () ?? "";
         if (input.Length > 0 && input.Any (char.IsLetter) &&
             input.All (c => char.IsLetter (c) || char.IsWhiteSpace (c))) return input;
         WriteLine ("Invalid input. Enter only letters and spaces.");
      }
   }

   // Counts character frequencies (ignoring spaces and case), and returns the character with the
   // highest frequency. If there's a tie, the one appearing earliest in the string wins.
   static (char winner, int count) CountVotes (string s) {
      Dictionary<char, (int Count, int FirstIndex)> freq = [];
      for (int i = 0; i < s.Length; i++) {
         char c = s[i];
         if (char.IsWhiteSpace (c)) continue;
         c = char.ToLower (c);
         freq[c] = freq.TryGetValue (c, out var info) ? (info.Count + 1, info.FirstIndex) : (1, i);
      }
      char winner = '\0';
      int maxCount = 0;
      int earliestIndex = int.MaxValue;
      foreach (var kvp in freq) {
         var (count, index) = kvp.Value;
         if (count > maxCount || (count == maxCount && index < earliestIndex)) {
            winner = kvp.Key;
            maxCount = count;
            earliestIndex = index;
         }
      }
      return (winner, maxCount);
   }
}
