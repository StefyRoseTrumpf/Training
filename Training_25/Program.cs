// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T02 branch - Assignment Q2.
// ------------------------------------------------------------------------------------------------
internal class Program {
   static void Main (string[] args) {
      (int, string)[] romanSymbol = { (1000,"M"),(900,"CM"),(500,"D"),(400,"CD"),(100,"C"),(90,"XC"),(50,"LX"),(40,"XL"),
                                            (10,"X"),(9,"IX"),(5,"V"),(4,"IV"),(1,"I")};

      Console.WriteLine ("Enter a number");
      string input = Console.ReadLine ();
      int num;

      while (!int.TryParse (input, out num)) {
         Console.WriteLine ("Invalid input.Please enter a valid number:");
         input = Console.ReadLine ();
      }

      while (true) {
         Console.WriteLine ($"Input:{num},\nConvert {num} to Roman or Words? (Enter roman/word)");

         string userChoice = Console.ReadLine ();


         if (userChoice.ToLower ().Trim () == "roman") {

            string roman = ConvertToRoman (num, romanSymbol);
            Console.WriteLine ($"Roman:{roman}");
            break;
         } else if (userChoice.ToLower ().Trim () == "word") {
            string word = ConvertToWords (num);
            Console.WriteLine (word);
            break;
         } else {
            Console.WriteLine ("Enter a valid choice - Roman or Word");
         }
      }


      static string ConvertToRoman (int number, (int, string)[] romanSymbol) {

         string output = "";

         foreach (var (value, symbol) in romanSymbol) {
            while (number >= value) {
               output += symbol;
               number -= value;
            }

         }
         return output;

      }

      static string ConvertToWords (int number) {
         if (number == 0) {
            return "Zero";
         }

         if (number < 0) {
            return "Minus" + ConvertToWords (Math.Abs (number));
         }

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
            string[] ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };

            if (number < 20) {
               words += ones[number];
            } else {
               words += tens[number / 10];
               if ((number % 10) > 0) {
                  words += " " + ones[number % 10];
               }

            }

         }

         return words;
      }

      Console.ReadLine ();
   }
}

