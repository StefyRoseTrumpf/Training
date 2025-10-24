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
         string input = (ReadLine () ?? "").Trim ().ToLower ();
         if (input.Length == 0 || input.Any (c => !char.IsLetter (c) && !char.IsWhiteSpace (c)))
            WriteLine ("Invalid input. Enter only letters and spaces.");
         else return input;
      }
   }

   // Counts character frequencies (ignoring spaces and case), and returns the character with the
   // highest frequency. If there's a tie, the one appearing earliest in the string wins.
   static (char Winner, int Count) CountVotes (string votes) {
      Dictionary<char, int> contest = [];
      foreach (char c in votes) {
         if (char.IsWhiteSpace (c)) continue;
         contest.TryAdd (c, 0);
         contest[c]++;
      }
      var winner = contest.MaxBy (c => c.Value);
      return (winner.Key, winner.Value);
   }
}
