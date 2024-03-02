namespace solid.OCP;

// Specification pattern. Not a GoF pattern.
public interface ISpecification<T>
{
    bool IsSatisfied(T candidate);
}
