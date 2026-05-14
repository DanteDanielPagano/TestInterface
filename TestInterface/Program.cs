namespace TestInterface;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Imprimiendo...");
        IPrinter printer;

        Console.WriteLine("Seleccione la impresora a utilizar:");
        Console.WriteLine("1 =  Láser Jet");
        Console.WriteLine("2 =  InkJet");

        string response = Console.ReadLine();


        switch (response)
        {
            case "1":
                printer = new LaserPrinter();

                printer.Print("Imprimir esto");

                Console.ReadKey();

                break;
            case "2":
                printer = new InkJetPrinter();

                printer.Print("Imprimir esto");

                Console.ReadKey();

                break;
        }

        Console.ReadKey();
    }
}
