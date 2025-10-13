// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      string s;
      while (true) {
         Write ("Enter a string: ");
         s = ReadLine ()?.Trim () ?? "";
         if (!string.IsNullOrEmpty (s) && s.Any (char.IsLetter)
            && s.All (c => char.IsLetter (c) || char.IsWhiteSpace (c))) break;
         WriteLine ("Invalid input. Please enter a valig string " +
                     "(Containing only letters (A - Z or a - z).");
      }
      var (winner, count) = CountVotes (s);
      WriteLine ($"Winner: {winner} and Votes: {count}");
   }

   // Counts character frequencies (ignoring spaces and case), and returns the character with the
   // highest frequency. If there's a tie, the one appearing earliest in the string wins.
   static (char winner, int count) CountVotes (string s) {
      Dictionary<char, (int Count, int FirstIndex)> freq = [];
      for (int i = 0; i < s.Length; i++) {
         char c = s[i];
         if (char.IsWhiteSpace (c)) continue;
         c = char.ToLower (c);
         if (!freq.TryGetValue (c, out var info))
            freq[c] = (1, i);
         else
            freq[c] = (info.Count + 1, info.FirstIndex);
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
