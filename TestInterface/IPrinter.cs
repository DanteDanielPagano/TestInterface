namespace TestInterface;

public interface IPrinter
{
    void Print(string content);

    bool IsOnline { get; }

    void OnOff();
}
