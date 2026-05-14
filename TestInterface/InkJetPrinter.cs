namespace TestInterface;

internal class InkJetPrinter : IPrinter, IExtendPrinter
{
    bool _isOnline = false;
    public bool IsOnline => _isOnline;


    public void Print(string content)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        content = content.ToLowerInvariant();
        Console.WriteLine("InkJet imprimiendo");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(content);
    }

    public void OnOff()
    {
        if (_isOnline)
        {
            _isOnline = false;
        }
        else
        {
            _isOnline = true;
        }
    }

    public void TunOn()
    {
        throw new NotImplementedException();
    }

    public void TunOff()
    {
        throw new NotImplementedException();
    }
}
