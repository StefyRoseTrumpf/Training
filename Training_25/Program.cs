// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Assignment 4: Chess Board
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main () {
      OutputEncoding = Encoding.UTF8;
      string[][] board =
      [
        ["♜","♞","♝","♛","♚","♝","♞","♜"],
        ["♟","♟","♟","♟","♟","♟","♟","♟"],
         ..Enumerable.Range(0, 4).Select(_ => EmptyRow()),
        ["♙", "♙", "♙", "♙", "♙", "♙", "♙", "♙"],
        ["♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖"]
        ];
      PrintBoard (board);
      WriteLine ("Press any key to exit..."); ReadKey ();
   }

   static string[] EmptyRow () => [.. Enumerable.Repeat (" ", 8)];

   static void PrintBoard (string[][] board) {
      string top = "┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓";
      string divider = "┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫";
      string bottom = "┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛";
      WriteLine (top);
      for (int i = 0; i < 8; i++) {
         WriteLine ($"┃{string.Join ("┃", board[i].Select (x => $" {x} "))}┃");
         WriteLine (i < 7 ? divider : bottom);
      }
   }
}