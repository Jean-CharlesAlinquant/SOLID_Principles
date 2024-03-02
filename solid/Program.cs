
// 1. Single Responsibility Principle (SRP)

// using solid.SRP;

// var journal = new JournalEntry();
// journal.AddEntry("I ate a banana.");
// journal.AddEntry("I got a cold.");
// Console.WriteLine(journal);

// 2. Open Closed Principle (OCP)

// using solid.OCP;

// var apple = new Product("Apple", Color.Green, Size.Small);
// var tree = new Product("Tree", Color.Green, Size.Large);
// var house = new Product("House", Color.Blue, Size.Large);

// Product[] products = { apple, tree, house };


// var greenFilter = new ProductFilter();
// Console.WriteLine("Green products (old):");
// foreach (var product in greenFilter.FilterByColor(products, Color.Green))
// {
//     Console.WriteLine($" - {product.Name} is green");
// }

// var betterFilter = new BetterFilter();
// Console.WriteLine("Green products (new):");
// foreach (var product in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
// {
//     Console.WriteLine($" - {product.Name} is green");
// }

// Console.WriteLine("Large blue products:");
// foreach (var product in betterFilter.Filter(
//     products,
//     new AndSpecification<Product>(
//         new ColorSpecification(Color.Blue),
//         new SizeSpecification(Size.Large))))
// {
//     Console.WriteLine($" - {product.Name} is large and blue");
// }

// 3. Liskov Substitution Principle (LSP)

// using solid.LSP;

// Rectangle rectangleBad = new Rectangle
// {
//     Width = 4,
//     Height = 5
// };
// Console.WriteLine($"Area: {rectangleBad.Area()}");

// If we substitute Square with Rectangle, we'll get an unexpected result.
// This is the violation of the LSP.
// Rectangle squareBad = new()
// {
//     Width = 4
// };
// Console.WriteLine($"Area: {squareBad.Area()}");

// RectangleClean rectangleGood = new RectangleClean
// {
//     Width = 4,
//     Height = 5
// };
// Console.WriteLine($"Area: {rectangleGood.Area()}");

// SquareClean squareGood = new SquareClean
// {
//     SideLength = 4
// };
// Console.WriteLine($"Area: {squareGood.Area()}");

// 4. Interface Segregation Principle (ISP)

// public class Document
// {
// }

// The IMachine interface has too many responsibilities.
// It violates the ISP. It should be split into several smaller interfaces.
// public interface IMachine
// {
//     void Print(Document document);
//     void Fax(Document document);
//     void Scan(Document document);
// }

// ok if you need a multifunction machine
// public class MultiFunctionPrinter : IMachine
// {
//     public void Print(Document document)
//     {
//         //
//     }

//     public void Fax(Document document)
//     {
//         //
//     }

//     public void Scan(Document document)
//     {
//         //
//     }
// }

// This class has to implement all the methods of the IMachine interface.
// But it only needs to implement the Print method.
// public class OldFashionedPrinter : IMachine
// {
//     public void Print(Document document)
//     {
//         // Ok
//     }

//     public void Fax(Document document)
//     {
//         // Not ok
//         throw new System.NotImplementedException();
//     }

//     public void Scan(Document document)
//     {
//         // Not ok
//         throw new System.NotImplementedException();
//     }
// }

// 5. Dependency Inversion Principle (DIP)
// High-level modules should not depend on low-level modules. 
// Both should depend on abstractions
// Instead of high-level modules directly depending on low-level modules, 
// both should depend on abstractions, such as interfaces or abstract base 
// classes.

// low-level module

// high-level module
using solid.DIP;

public class Research
{
    // high-level module depends on low-level module
    // public Research(Relationships relationships)
    // {
    //     var relations = relationships.Relations;
    //     foreach (var relation in relations.Where(
    //         x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
    //     {
    //         Console.WriteLine($"John has a child called {relation.Item3.Name}");
    //     }
    // }

    // Now the high-level module depends on abstraction
    public Research(IRelationshipBrowser browser)
    {
        foreach (var child in browser.FindAllChildrenOf("John"))
        {
            Console.WriteLine($"John has a child called {child.Name}");
        }
    }

    static void Main(string[] args)
    {
        var parent = new Person { Name = "John" };
        var child1 = new Person { Name = "Chris" };
        var child2 = new Person { Name = "Mary" };

        var relationships = new Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2);

        new Research(relationships);
    }
}

