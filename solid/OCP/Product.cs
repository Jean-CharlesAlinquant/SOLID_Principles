namespace solid.OCP;

public class Product
{
    public string Name { get; }
    public Color Color { get; }
    public Size Size { get; }

    public Product(string name, Color color, Size size)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        Color = color;
        Size = size;
    }
}
