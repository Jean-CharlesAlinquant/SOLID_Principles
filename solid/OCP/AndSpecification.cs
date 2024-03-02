namespace solid.OCP;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first;
        _second = second;
    }

    public bool IsSatisfied(T candidate)
    {
        return _first.IsSatisfied(candidate) && _second.IsSatisfied(candidate);
    }
}
