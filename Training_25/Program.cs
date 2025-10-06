// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T04 branch. Assignment Q4: Chess Board
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training_25;

internal class Program {
   static void Main (string[] args) {
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
      ReadLine ();
   }

   static string[] EmptyRow () => [.. Enumerable.Repeat (" ", 8)];

   static void PrintBoard (string[][] board) {
      string top = "┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓";
      string divider = "┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫";
      string bottom = "┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛";
      WriteLine (top);
      for (int i = 0; i < 8; i++) {
         WriteLine ("┃" + string.Join ("┃", board[i].Select (x => $" {x} ")) + "┃");
         WriteLine (i < 7 ? divider : bottom);
      }
   }
}