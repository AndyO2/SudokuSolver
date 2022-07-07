using SudokuSolver;

//First index represents what row (up and down)
//Second index represents what column (left and right)
int[,] solve = new int[,]
{
    { 0, 8, 1, 2, 3, 4, 5, 0, 6 },
    { 0, 9, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 7, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 6, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
    { 5, 4, 1, 2, 3, 4, 5, 0, 5 },
    { 0, 0, 1, 2, 3, 4, 5, 0, 5 },
};

Solver s = new Solver(solve);

//Console.WriteLine(s.CheckColumnIsValid(2,1));

for(int i = 1; i <= 9; i++)
{
    Console.WriteLine(i + " : " + s.CheckSubGridIsValid(7, 0, i));
}




