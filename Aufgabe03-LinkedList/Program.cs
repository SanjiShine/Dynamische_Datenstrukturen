namespace Aufgabe03_LinkedList;

class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Elemente zur Liste hinzufügen
        list.Add("1.Apfel");
        list.Add("2.Birne");
        list.Add("3.Wassermelone");

        // Elemente über den Indexer ausgeben
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Element an Index {i} : {list[i]}");
        }

        // Wert eines Elements über den Indexer aktualisieren
        list[1] = "2.Mango";

        // Aktualisierten Wert erneut ausgeben
        Console.WriteLine("Nach der Aktualisierung:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Element an Index {i} : {list[i]}");
        }

        // Test auf IndexOutOfRangeException
        try
        {
            Console.WriteLine(list[3]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
