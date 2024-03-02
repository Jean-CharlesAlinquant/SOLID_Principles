namespace solid.DIP;
public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}

