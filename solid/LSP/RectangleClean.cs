namespace solid.LSP;

public class RectangleClean : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }
}
