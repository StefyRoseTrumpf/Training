// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T08 branch. Assignment Q8: Strong Password.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a password:");
      string? password = ReadLine ();
      while (string.IsNullOrWhiteSpace (password)) {
         WriteLine ("Password cannot be empty.\nEnter a password:");
         password = ReadLine ();
      }
      string reason = IsPasswordStrong (password!);
      if (string.IsNullOrEmpty (reason))
         WriteLine ("Password is strong.");
      else {
         WriteLine ("Password is weak.\nReasons:");
         WriteLine (reason);
      }
      ReadLine ();
   }

   static string IsPasswordStrong (string password) {
      string reason = "";
      if (password.Length < 6)
         reason += "- Password should contain at least 6 characters.\n";
      bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;
      foreach (char c in password) {
         if (char.IsUpper (c)) hasUpper = true;
         else if (char.IsLower (c)) hasLower = true;
         else if (char.IsDigit (c)) hasDigit = true;
         else if ("!@#$%^&*()-+".Contains (c)) hasSpecial = true;
      }
      if (!hasUpper) reason += "- Password should contain at least one uppercase letter.\n";
      if (!hasLower) reason += "- Password should contain at least one lowercase letter.\n";
      if (!hasDigit) reason += "- Password should contain at least one digit.\n";
      if (!hasSpecial) reason += "- Password should contain at least one special character (!@#$%^&*()-+).\n";
      return reason;
   }
}
