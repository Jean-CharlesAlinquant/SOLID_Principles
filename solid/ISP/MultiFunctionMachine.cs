namespace solid.ISP;

interface IMultifunctionDevice
{

}

public struct MultiFunctionMachine : IMultifunctionDevice
{
    // compose this out of several modules
    private IPrinter _printer;
    private IScanner _scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        if (printer == null)
        {
            throw new ArgumentNullException(paramName: nameof(printer));
        }
        if (scanner == null)
        {
            throw new ArgumentNullException(paramName: nameof(scanner));
        }
        this._printer = printer;
        this._scanner = scanner;
    }

    public void Print(Document document)
    {
        // Decorator pattern
        _printer.Print(document);
    }

    public void Scan(Document document)
    {
        // Decorator pattern
        _scanner.Scan(document);
    }
}

