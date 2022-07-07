using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Solver
    {
        /// <summary>
        /// Constructor that takes in the Sudoku board we want to solve
        /// </summary>
        /// <param name="boardToSolve">The board we are solving</param>
        public Solver(int[,] boardToSolve)
        {
            board = boardToSolve;
        }

        /// <summary>
        /// The board we want to solve
        /// </summary>
        private int[,] board;

        /// <summary>
        /// Determines if the value at the location on the board is a possible value (1-9)
        /// </summary>
        /// <param name="board">The board we are solving</param>
        /// <param name="row">row we are checking</param>
        /// <param name="column">column we are checking</param>
        /// <param name="value">value we are inserting</param>
        /// <returns></returns>
        public bool IsPossible(int row, int column, int value)
        {
            ////1) If there is no other instances of the value in the same row
            //CheckRowIsValid(row, value);

            ////2) If there is no other instances of the value in the same column
            //CheckColumnIsValid(column, value);

            ////3) If there is no other instances of the value in the same 3x3 grid
            //CheckSubGridIsValid(row, column, value);

            return CheckRowIsValid(row,value) && CheckColumnIsValid(column, value) && CheckSubGridIsValid(row, column, value);
        }

        /// <summary>
        /// Check if the value is valid in the corresponding 3x3 subgrid it is in
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckSubGridIsValid(int row, int column, int value)
        {
            //LEFT COLUMN
            if (column >= 0 && column <= 2)
            {
                //Top left 3x3 quadrant
                if (row >= 0 && row < 3)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
                //Middle left 3x3 quadrant
                else if (row >= 3 && row < 6)
                {
                    for(int i = 3; i < 6; i++)
                    {
                        for(int j = 0; j < 3; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
                //Bottom left 3x3 quadrant
                else if (row >= 6 && row < 9)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
            }
            //MIDDLE COLUMN
            else if (column >= 3 && column <= 5)
            {
                //Top Middle 3x3 quadrant
                if (row >= 0 && row < 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for(int j = 3; j < 6; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
                //Middle Middle 3x3 quadrant
                else if (row >= 3 && row < 6)
                {
                    for (int i = 3; i < 6; i++)
                    {
                        for (int j = 3; j < 6; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
                //Bottom Middle 3x3 quadrant
                else if (row >= 6 && row < 9)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        for (int j = 3; j < 6; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
            }
            //RIGHT COLUMN
            else if (column >= 6 && column <= 8)
            {
                //Top Right 3x3 quadrant
                if (row >= 0 && row < 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 6; j < 9; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
                //Middle Right 3x3 quadrant
                else if (row >= 3 && row < 6)
                {
                    for (int i = 3; i < 6; i++)
                    {
                        for (int j = 6; j < 9; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
                //Bottom Right 3x3 quadrant
                else if (row >= 6 && row < 9)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        for (int j = 6; j < 9; j++)
                        {
                            if (board[i, j] == value) return false;
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if the value in this column is valid
        /// </summary>
        /// <param name="col"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckColumnIsValid(int col, int value)
        {
            if (col is 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 2)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 3)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 4)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 5)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 6)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 7)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }
            else if (col is 8)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, col] == value) return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if this value in this row is valid
        /// </summary>
        /// <param name="row"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckRowIsValid(int row, int value)
        {
            if (row is 0)
            {
                for(int i = 0; i < 9; i++)
                {
                    if (board[row,i] == value) return false;
                }
            }
            else if (row is 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }
            else if (row is 2)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }
            else if (row is 3)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }
            else if (row is 4)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }
            else if (row is 5)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }
            else if (row is 6)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }
            else if (row is 7)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }
            else if (row is 8)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == value) return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Recursive method that solves the sudoku problem
        /// </summary>
        public void Solve()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //When we find a 0, that means we found an empty square
                    if (board[i,j] == 0)
                    {
                        //Loop through all possible options
                        for (int k = 1; k < 10; k++)
                        {
                            if (IsPossible(i, j, k))
                            {
                                //If this location is a possible value for the value k, insert it and solve the next empty cell
                                board[i, j] = k;
                                //Recursive call, after inserting a possible value, call this again to find and fill the next empty cell
                                Solve();
                                //If we run out of values, we backtrack and remove the previous value we inserted
                                board[i, j] = 0;
                            }
                        }
                        return;
                    }
                }
            }
            PrintBoard();
        }

        //Helper method that prints the solution
        private void PrintBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + " ");
                    if (j == 8) Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
