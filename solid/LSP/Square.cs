namespace solid.LSP;

// The Square class inherits from Rectangle, suggesting an "is-a" relationship.
// However, in reality, a Square is not a specialized type of Rectangle. 
// This misuse of inheritance leads to incorrect behavior and violates LSP 

public class Square : Rectangle
{
    public override int Width
    {
        get => base.Width;
        set => base.Width = base.Height = value;
    }

    public override int Height
    {
        get => base.Height;
        set => base.Height = base.Width = value;
    }
}
