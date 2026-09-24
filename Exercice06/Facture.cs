public class Facture : IImprimable, IExportable
{
    public int Numero { get; set; }

    public Facture(int numero)
    {
        Numero = numero;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Impression facture n°{Numero}");
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"Export facture vers {fichier}");
    }
}