namespace solid.LSP;

public class SquareClean : IShape
{
    public int SideLength { get; set; }

    public int Area()
    {
        return SideLength * SideLength;
    }
}
