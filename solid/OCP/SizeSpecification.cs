namespace solid.OCP;

public class SizeSpecification : ISpecification<Product>
{
    public Size Size { get; }

    public SizeSpecification(Size size)
    {
        Size = size;
    }

    public bool IsSatisfied(Product candidate)
    {
        return candidate.Size == Size;
    }
}
