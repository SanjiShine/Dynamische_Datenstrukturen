namespace Aufgabe04_Personenliste;

class Program
{
    static void Main(string[] args)
    {
        Personenliste freunde = new Personenliste();
        freunde.AddSorted("Berta");
        freunde.AddSorted("Claudia");
        freunde.AddSorted("Anton");
        freunde.AddSorted("Baerbel");
        freunde.PrintAll();
        freunde.AddFront("Hans");
        freunde.AddEnd("Franz");
        freunde.Print();
        freunde.DeleteFirst();
        freunde.DeleteLast();
        freunde.DeleteByName("Berta");
        freunde.Print();
        freunde.PrintReverse();
    }
}

