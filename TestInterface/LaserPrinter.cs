namespace TestInterface;

internal class LaserPrinter : IPrinter
{
    public bool IsOnline { get; set; }

    public void Print(string content)
    {
        if (_onOff)
        {
            content = content.ToUpperInvariant();
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("Impresora fuera de línea");
            // esta línea es nueva
        }

    }

    bool _onOff = false;
    public void OnOff()
    {
        if (!_onOff)
        {
            _onOff = true;
            IsOnline = true;
        }
        else
        {
            _onOff = false;
            IsOnline = false;
        }
    }

}
