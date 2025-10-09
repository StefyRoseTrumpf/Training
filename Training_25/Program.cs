// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check if a given password is strong or weak.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      string password = ReadValidPassword ("Enter a password: ");
      string reason = CheckPasswordStrength (password!);
      if (string.IsNullOrEmpty (reason))
         WriteLine ("Password is strong.");
      else {
         WriteLine ("Password is weak.\nReasons: ");
         WriteLine (reason);
      }
   }

   /// <summary>Continuously prompts the user until a non-empty password is entered.</summary>
   static string ReadValidPassword (string prompt) {
      while (true) {
         Write (prompt);
         string? input = ReadLine ();
         if (!string.IsNullOrWhiteSpace (input))
            return input.Trim ();
         WriteLine ("Password cannot be empty.");
      }
   }

   /// <summary>Checks password strength based on length, uppercase, lowercase, digit, and special characters.
   /// Returns reasons if it's weak.</summary>
   static string CheckPasswordStrength (string password) {
      var reasons = new List<string> ();
      if (password.Length < 6)
         reasons.Add ("- Password should contain at least 6 characters.");
      if (!password.Any (char.IsUpper))
         reasons.Add ("- Password should contain at least one uppercase letter.");
      if (!password.Any (char.IsLower))
         reasons.Add ("- Password should contain at least one lowercase letter.");
      if (!password.Any (char.IsDigit))
         reasons.Add ("- Password should contain at least one digit.");
      if (!password.Any (c => "!@#$%^&*()-+".Contains (c)))
         reasons.Add ("- Password should contain at least one special character (!@#$%^&*()-+).");
      return string.Join ("\n", reasons);
   }
}