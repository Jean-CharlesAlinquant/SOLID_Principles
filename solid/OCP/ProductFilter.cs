namespace solid.OCP;

// This class violates the OCP
// We have to add new methods to the class every time we need to add a new filter.

public class ProductFilter
{
    public IEnumerable<Product> FilterBySize(
        IEnumerable<Product> products, Size size)
    {
        foreach (var product in products.Where(product => product.Size == size))
        {
            yield return product;
        }
    }

    public IEnumerable<Product> FilterByColor(
    IEnumerable<Product> products, Color color)
    {
        foreach (var product in products.Where(product => product.Color == color))
        {
            yield return product;
        }
    }

    // This is the violation of the OCP.
    public IEnumerable<Product> FilterBySizeAndColor(
    IEnumerable<Product> products, Size size, Color color)
    {
        foreach (var product in products.Where(product => product.Size == size &&
                                                          product.Color == color))
        {
            yield return product;
        }
    }
}