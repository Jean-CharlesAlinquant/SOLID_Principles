namespace solid.OCP;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> specification)
    {
        foreach (var product in products.Where(specification.IsSatisfied))
        {
            yield return product;
        }
    }
}
