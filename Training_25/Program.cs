// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check if a given password is strong or weak.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training_25;

internal class Program {
   static void Main () {
      string reason = CheckPasswordStrength (ReadValidPassword ("Enter a password: "));
      WriteLine (string.IsNullOrEmpty (reason)
        ? "Password is strong." : $"Password is weak. Ensure it includes:\n{reason}");
   }

   // Continuously prompts the user until a non-empty password is entered.
   static string ReadValidPassword (string prompt) {
      while (true) {
         Write (prompt);
         string? input = ReadLine ();
         if (!string.IsNullOrWhiteSpace (input)) return input.Trim ();
         WriteLine ("Password cannot be empty.");
      }
   }

   // Checks password strength based on length, uppercase, lowercase, digit and special characters.
   // Returns reasons if it's weak.
   static string CheckPasswordStrength (string password) {
      var sb = new StringBuilder ();
      if (password.Length < 6) sb.AppendLine ("- At least 6 characters.");
      if (!password.Any (char.IsUpper))
         sb.AppendLine ("- At least one uppercase letter.");
      if (!password.Any (char.IsLower))
         sb.AppendLine ("- At least one lowercase letter.");
      if (!password.Any (char.IsDigit))
         sb.AppendLine ("- At least one digit.");
      if (password.All (char.IsLetterOrDigit))
         sb.AppendLine ("- At least one special character.");
      return sb.ToString ();
   }
}
