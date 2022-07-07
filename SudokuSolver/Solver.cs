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
            //1) If there is no other instances of the value in the same row

            //2) If there is no other instances of the value in the same column

            //3) If there is no other instances of the value in the same 3x3 grid

            return false;
        }

        public void Solve()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //When we find a 0, that means we found an empty square
                    if (board[i,j] == 0)
                    {

                    }
                }
            }
        }
    }
}
