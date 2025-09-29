// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T02 branch - Assignment Q2: NUMBER TO WORDS AND ROMAN NUMERALS CONVERTER.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using static System.Math;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a number.");
      int num;
      string? input;
      while (!int.TryParse (input = ReadLine (), out num))
         WriteLine ("Invalid input. Please enter a valid number: ");
      string userChoice = "";
      while (userChoice != "roman" && userChoice != "word") {
         WriteLine ($"Input:{num}\nConvert {num} to Roman or Words? (Enter roman/word)");
         userChoice = ReadLine ()?.ToLower ().Trim () ?? "";
         if (userChoice != "roman" && userChoice != "word")
            WriteLine ("Invalid choice! Please enter 'roman' or 'word'.");
      }
      switch (userChoice) {
         case "roman":
            string roman = ConvertToRoman (num); WriteLine ($"Roman:{roman}");
            break;
         case "word":
            string word = ConvertToWords (num); WriteLine ($"Word:{word}");
            break;         
      }

      static string ConvertToRoman (int number) {
         (int, string)[] romanSymbol = [ (1000,"M"),(900,"CM"),(500,"D"),(400,"CD"),(100,"C"),(90,"XC"),(50,"L"),(40,"XL"),
                                            (10,"X"),(9,"IX"),(5,"V"),(4,"IV"),(1,"I")];
         if (number == 0) return "N";
         string output = "";
         if (number < 0) {
            output += "-";
            number = Abs (number);
         }
         foreach (var (value, symbol) in romanSymbol) {
            while (number >= value) {
               output += symbol;
               number -= value;
            }
         }
         return output;
      }

      static string ConvertToWords (int number) {
         if (number == 0) return "Zero";
         if (number < 0) return "Minus " + ConvertToWords (Abs (number));
         string words = "";
         if ((number / 1000000) > 0) {
            words += ConvertToWords (number / 1000000) + " Million ";
            number %= 1000000;
         }
         if ((number / 100000) > 0) {
            words += ConvertToWords (number / 100000) + " Lakh ";
            number %= 100000;
         }
         if ((number / 1000) > 0) {
            words += ConvertToWords (number / 1000) + " Thousand ";
            number %= 1000;
         }
         if ((number / 100) > 0) {
            words += ConvertToWords (number / 100) + " Hundred ";
            number %= 100;
         }
         if (number > 0) {
            string[] ones = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
            string[] tens = ["Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
            if (number < 20) words += ones[number];
            else {
               words += tens[number / 10];
               if ((number % 10) > 0) words += " " + ones[number % 10];
            }
         }
         return words;
      }
      ReadLine ();
   }
}


