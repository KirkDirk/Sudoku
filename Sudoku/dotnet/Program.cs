﻿using static System.Console;

int ElementException(int xEE, int yEE, int[][] boardEE)
{

}

int[][] startingBoard = {

  new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 },
  new int[] { 0, 2, 0, 0, 0, 0, 0, 0, 0 },
  new int[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 },

  new int[] { 0, 0, 0, 4, 0, 0, 0, 0, 0 },
  new int[] { 0, 0, 0, 0, 5, 0, 0, 0, 0 },
  new int[] { 0, 0, 0, 0, 0, 6, 0, 0, 0 },

  new int[] { 0, 0, 0, 0, 0, 0, 7, 0, 0 },
  new int[] { 0, 0, 0, 0, 0, 0, 0, 8, 0 },
  new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 9 },
  };

int[][][] availableBoard = new int[][][10];
for (int i = 0; i < startingBoard.GetLength(0); i++)
{
    for (int j = 0; j < startingBoard.GetLength(1); j++)
    {
        if (startingBoard[i, j] != 0) availableBoard[i, j, 0] = startingBoard[i, j];
        else
        {
            for (int k = 0; k < availableBoard.GetLength(2); k++)
            { 
              availableBoard[i,j,k]=
            }
        }

    }
}


// (int, int) EmptyElPosition(int[][] board)
// {
//   int size = board.Length;
//   for (int x = 0; x < size; x++)
//     for (int y = 0; y < size; y++)
//       if (board[x][y] == 0)
//         return (x, y);
//   return (-1, -1);
// }

// int[] GetColumn(int[][] board, int y)
// {
//   int size = board.Length;
//   int[] temp = new int[size];
//   for (int x = 0; x < size; x++)
//     temp[x] = board[x][y];
//   return temp;
// }

// bool ValidElementInPosition(int[][] board, int el, int x, int y)
// {
//   if (
//     Array.IndexOf(board[x], el) != -1
//    || Array.IndexOf(GetColumn(board, y), el) != -1
//   ) return false;

//   int row = (x / 3) * 3;
//   int col = (y / 3) * 3;
//   for (int r = row; r < row + 3; r++)
//     for (int c = col; c < col + 3; c++)
//       if (board[r][c] == el) return false;
//   return true;
// }

// bool Fill(int[][] board)
// {
//   (int row, int col) = EmptyElPosition(board);
//   if (row == -1) return true;
//   for (int el = 1; el < 10; el++)
//   {
//     if (ValidElementInPosition(board, el, row, col))
//     {
//       board[row][col] = el;
//       if (Fill(board)) return true;
//     }
//     board[row][col] = 0;
//   }
//   return false;
// }

// void Print(int[][] board)
// {
//   Clear();
//   int i = 1;
//   int j = 1;
//   foreach (var line in board)
//   {
//     j = 1;
//     foreach (var item in line)
//     {
//       if (j % 3 == 0)
//         Write($"{item}   ");
//       else
//         Write($"{item} ");
//       j += 1;
//     }
//     if (i % 3 == 0)
//       WriteLine("\n");
//     else
//       WriteLine();
//     i += 1;
//   }
// }

// int[][] board = {

//   new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 },
//   new int[] { 0, 2, 0, 0, 0, 0, 0, 0, 0 },
//   new int[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 },

//   new int[] { 0, 0, 0, 4, 0, 0, 0, 0, 0 },
//   new int[] { 0, 0, 0, 0, 5, 0, 0, 0, 0 },
//   new int[] { 0, 0, 0, 0, 0, 6, 0, 0, 0 },

//   new int[] { 0, 0, 0, 0, 0, 0, 7, 0, 0 },
//   new int[] { 0, 0, 0, 0, 0, 0, 0, 8, 0 },
//   new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 9 },
//   };

// var res = Fill(board);
// Print(board);
// WriteLine($"res: {res}");