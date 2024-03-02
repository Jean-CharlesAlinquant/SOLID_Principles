namespace solid.DIP;

// low-level module
public class Relationships : IRelationshipBrowser
{
    private readonly List<(Person, Relationship, Person)> _relations = new();

    public void AddParentAndChild(Person parent, Person child)
    {
        _relations.Add((parent, Relationship.Parent, child));
        _relations.Add((child, Relationship.Child, parent));
    }

    // Not ideal => Have to make this public so that it is accessible
    // The class allows its data store to be accessible.
    // This should really remains private.
    // public List<(Person, Relationship, Person)> Relations => _relations;

    // Dependency Inversion with introduction of IRelationshipBrowser
    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        return _relations.Where(x => x.Item1.Name == name &&
                                     x.Item2 == Relationship.Parent)
                         .Select(x => x.Item3);
    }
}

