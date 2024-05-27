namespace Aufgabe02_Büchersammlung;

class Program
{
    static void Main(string[] args)
    {
        BookCollection book = new BookCollection();

        book.AddBook(new Book("A little life", "Hanya Yanagihara", 810));
        book.AddBook(new Book("The fault in our stars", "John Green", 350));
        book.AddBook(new Book("Looking for Alaska", "John Green", 280));
        book.AddBook(new Book("The girl on the train","Paula Hawkins", 320));

        book.PrintBooksByAuthor("John Green");
        book.PrintAllBooks();

        book.RemoveBooksByAuthor("John Green");
        book.PrintAllBooks();



    }
}

