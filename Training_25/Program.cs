// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Assignment 2: NUMBER TO WORDS AND ROMAN NUMERALS CONVERTER.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      WriteLine ("Enter a number: ");
      int num;
      while (!int.TryParse (ReadLine (), out num))
         WriteLine ("Invalid input. Please enter a valid number: ");
      string? userChoice;
      while (true) {
         WriteLine ($"Input: {num}\nConvert {num} to Roman or Words? (Enter roman/word)");
         userChoice = ReadLine ()?.ToLower ().Trim ();
         switch (userChoice) {
            case "roman": WriteLine (ConvertToRoman (num)); break;
            case "word": WriteLine (ConvertToWords (num)); break;
            default: WriteLine ("Invalid choice! Please enter 'roman' or 'word'."); continue;
         }
         break;
      }
   }

   static string ConvertToRoman (int number) {
      (int, string)[] romanSymbol = [ (1_000,"M"),(900,"CM"),(500,"D"),(400,"CD"),(100,"C"),
                   (90,"XC"),(50,"L"),(40,"XL"),(10,"X"),(9,"IX"),(5,"V"),(4,"IV"),(1,"I")];
      if (number == 0) return "N";
      string output = "";
      if (number < 0) (output, number) = ("-", -number);
      foreach (var (value, symbol) in romanSymbol)
         while (number >= value) (output, number) = (output + symbol, number - value);
      return output;
   }

   static string ConvertToWords (int number) {
      if (number == 0) return "Zero";
      if (number < 0) return "Minus " + ConvertToWords (-number);
      string words = "";
      if ((number / 1_000_000) > 0) {
         words += $"{ConvertToWords (number / 1_000_000)} Million ";
         number %= 1_000_000;
      }
      if ((number / 1_000) > 0) {
         words += $"{ConvertToWords (number / 1_000)} Thousand ";
         number %= 1_000;
      }
      if ((number / 100) > 0) {
         words += $"{ConvertToWords (number / 100)} Hundred ";
         number %= 100;
      }
      if (number > 0)
         words += number < 20
           ? sOnes[number] : $"{sTens[number / 10]}{(number % 10 != 0 ? $" {sOnes[number % 10]}" : "")}";
      return words.Trim ();
   }
   static string[] sOnes = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                           "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                           "Sixteen","Seventeen", "Eighteen", "Nineteen"],
                   sTens = ["Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy"
                           ,"Eighty", "Ninety"];
}