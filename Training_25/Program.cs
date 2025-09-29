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
      string[,] board =
      {
        { "♜","♞","♝","♛","♚","♝","♞","♜" },
        { "♟","♟","♟","♟","♟","♟","♟","♟" },
        { " "," "," "," "," "," "," "," " },
        { " "," "," "," "," "," "," "," " },
        { " "," "," "," "," "," "," "," " },
        { " "," "," "," "," "," "," "," " },
        { "♙","♙","♙","♙","♙","♙","♙","♙" },
        { "♖","♘","♗","♕","♔","♗","♘","♖" }
        };
      PrintBoard (board);
      ReadLine ();
   }

   static void PrintBoard (string[,] board) {
      string top = "┏━━━━━━━━┳━━━━━━━━┳━━━━━━━━┳━━━━━━━━┳━━━━━━━━┳━━━━━━━━┳━━━━━━━━┳━━━━━━━━┓" +
                 "\n┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃";
      string divider = "┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃" +
                     "\n┣━━━━━━━━╋━━━━━━━━╋━━━━━━━━╋━━━━━━━━╋━━━━━━━━╋━━━━━━━━╋━━━━━━━━╋━━━━━━━━┫" +
                     "\n┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃";
      string bottom = "┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃        ┃" +
                    "\n┗━━━━━━━━┻━━━━━━━━┻━━━━━━━━┻━━━━━━━━┻━━━━━━━━┻━━━━━━━━┻━━━━━━━━┻━━━━━━━━┛";
      WriteLine (top);
      for (int i = 0; i < 8; i++) {
         Write ("┃");
         for (int j = 0; j < 8; j++)
            Write ($"   {board[i, j]}    ┃");
         WriteLine ();
         if (i < 7) WriteLine (divider);
         else WriteLine (bottom);
      }
   }
}