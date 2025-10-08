// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to display chess board with all peices
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      OutputEncoding = Encoding.UTF8;
      string[] empty = [.. Enumerable.Repeat (" ", 8)];
      string[][] board =
      [
        ["♜","♞","♝","♛","♚","♝","♞","♜"],
        ["♟","♟","♟","♟","♟","♟","♟","♟"],
        .. Enumerable.Repeat (empty, 4),
        ["♙", "♙", "♙", "♙", "♙", "♙", "♙", "♙"],
        ["♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖"]
        ];
      PrintBoard (board);
      WriteLine ("Press any key to exit..."); ReadKey ();
   }

   /// <summary> Prints a formatted 8×8 chessboard with Unicode borders and pieces.</summary>
   /// <param name="board">A 2D string array representing the chessboard pieces in initial position.</param>
   static void PrintBoard (string[][] board) {
      string top = "┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓";
      string divider = "┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫";
      string bottom = "┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛";
      WriteLine (top);
      for (int i = 0; i < 8; i++) {
         WriteLine ($"┃ {string.Join (" ┃ ", board[i])} ┃");
         WriteLine (i < 7 ? divider : bottom);
      }
   }
}