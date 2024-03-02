namespace solid.OCP;

// The filter method can be used to filter a list of products by a given specification.
public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
}
