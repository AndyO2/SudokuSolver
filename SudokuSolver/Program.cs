﻿using SudokuSolver;

//First index represents what row (up and down)
//Second index represents what column (left and right)
int[,] solve = new int[,]
{
    { 3, 0, 0, 8, 0, 1, 0, 0, 2 },
    { 2, 0, 1, 0, 3, 0, 6, 0, 4 },
    { 0, 0, 0, 2, 0, 4, 0, 0, 0 },
    { 8, 0, 9, 0, 0, 0, 1, 0, 6 },
    { 0, 6, 0, 0, 0, 0, 0, 0, 0 },
    { 7, 0, 2, 0, 0, 0, 4, 0, 9 },
    { 0, 0, 0, 5, 0, 9, 0, 0, 0 },
    { 9, 0, 4, 0, 8, 0, 7, 0, 5 },
    { 6, 0, 0, 1, 0, 7, 0, 0, 3 },
};

Console.WriteLine("BOARD TO SOLVE");
for(int i = 0; i < 9; i++)
{
    for(int j = 0; j < 9; j++)
    {
        Console.Write(solve[i,j] + " ");
        if (j == 8) Console.WriteLine();
    }
}

Console.WriteLine("\nPress 'Enter' for Solution(s)");
Console.Read();

Console.WriteLine("SOLUTION(S)");
Solver s = new Solver(solve);
s.Solve();





