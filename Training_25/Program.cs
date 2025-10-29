// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program returns true or false if the given number is 3x3 magic square ie sum of every
// column, every row ans diagonals are same.
// ------------------------------------------------------------------------------------------------
using System.Numerics;
using static System.Console;
namespace Training_25;
internal class Program {
   static void Main () {
      string? input;
      while (true) {
         WriteLine ("Enter 9 numbers separated by comma for 3x3 matrix:");
         input = ReadLine ();
         if (input == null || input.Length != 17 ){
            WriteLine ("Invalid Input. Enter 9 numbers only separated by ','.");
            continue;
         }
         break;
      }
      int[] matrix = [.. input.Split(',').Select(int.Parse)];
      WriteLine(IsMagicSquare(new int[,] { { matrix[0], matrix[1], matrix[2] }, { matrix[3], matrix[4], matrix[5] }, { matrix[6], matrix[7], matrix[8] } }));
      //WriteLine ("Enter 9 numbers for 3x3 matrix:");
      //string? input = ReadLine ();

      //new int[3, 3] = ReadLine();

      //WriteLine ( IsMagicSquare (new int[,] { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } }) ); // true
   }

   static bool IsMagicSquare (int[,] matrix) {
      int n = 3;
      int sumDiagonal1 = 0, sumDiagonal2 = 0;
      for (int i = 0; i < n; i++) {
         sumDiagonal1 += matrix[i, i];
         sumDiagonal2 += matrix[i, n - i - 1];
      }
      if (sumDiagonal1 != sumDiagonal2)
         return false;
      for (int i = 0; i < n; i++) {
         int sumRow = 0, sumCol = 0;
         for (int j = 0; j < n; j++) {
            sumRow += matrix[i, j];
            sumCol += matrix[j, i];
         }
         if (sumRow != sumDiagonal1 || sumCol != sumDiagonal1)
            return false;
      }
      return true;
   }
}
