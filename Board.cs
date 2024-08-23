using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
public class ShoubuBoard
{
    private int size;
    public ShoubuBoard(int boardSize)
    {
        size = boardSize;
    }
    public ShoubuBoard(int boardSize, bool player)
    {
        size = boardSize;
    }
    
    public int Size
    {
        get { return size; }
    }
}

public class Toto : ShoubuBoard {
    public Toto(int boardSize, int toto) : base(boardSize, false) {
        ShoubuBoard board = new ShoubuBoard(toto);
        Console.WriteLine(board.Size);
    }
}