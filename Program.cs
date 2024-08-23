using System;

public static class Go
{
    public static void PrintBoard(ShoubuBoard shoubuBoard)
    {

    }
    public static void Main()
    {
        ShoubuBoard currBoard = new ShoubuBoard(5) ;
        Console.WriteLine(currBoard.Size);
    }
}

