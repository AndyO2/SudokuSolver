﻿using SudokuSolver;

int[,] solve = new int[,]
{
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
};

Solver s = new Solver(solve);

//Console.WriteLine(s.CheckColumnIsValid(2,1));

for(int i = 0; i < 9; i++)
{
    Console.WriteLine(i + " : " + s.CheckSubGridIsValid(2, 6, i));
}




