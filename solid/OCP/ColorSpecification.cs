namespace solid.OCP;

public class ColorSpecification : ISpecification<Product>
{
    public Color Color { get; }

    public ColorSpecification(Color color)
    {
        Color = color;
    }

    public bool IsSatisfied(Product candidate)
    {
        return candidate.Color == Color;
    }
}
