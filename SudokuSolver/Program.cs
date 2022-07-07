using SudokuSolver;

//First index represents what row (up and down)
//Second index represents what column (left and right)
int[,] solve = new int[,]
{
    { 0, 9, 4, 8, 3, 0, 1, 0, 0 },
    { 8, 1, 2, 7, 0, 0, 0, 9, 6 },
    { 3, 0, 0, 1, 9, 0, 0, 0, 0 },
    { 0, 3, 0, 9, 0, 4, 6, 0, 0 },
    { 0, 0, 8, 6, 1, 3, 0, 4, 9 },
    { 0, 0, 6, 2, 0, 0, 0, 0, 1 },
    { 4, 0, 3, 5, 0, 0, 0, 0, 8 },
    { 5, 0, 0, 0, 2, 0, 7, 0, 0 },
    { 0, 6, 0, 0, 0, 8, 4, 1, 5 },
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





