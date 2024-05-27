namespace Aufgabe03_LinkedList;

class Program
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Elemente zur Liste hinzufügen
        list.Add("Element 1");
        list.Add("Element 2");
        list.Add("Element 3");

        // Elemente über den Indexer ausgeben
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Element an Index {0}: {1}", i, list[i]);
        }

        // Wert eines Elements über den Indexer aktualisieren
        list[1] = "Aktualisiertes Element 2";

        // Aktualisierten Wert erneut ausgeben
        Console.WriteLine("Nach der Aktualisierung:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Element an Index {0}: {1}", i, list[i]);
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
