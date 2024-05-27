using System;
namespace Aufgabe02_Büchersammlung
{
	public class BookCollection
	{
		private Book[] books;
		int count;

		public BookCollection()
		{
			books = new Book[5];  // Initial capacity
            count = 0;
		}

        public void AddBook(Book book)
        {
            if (count == books.Length)
            {
                Array.Resize(ref books, books.Length * 2); // Double the array size if needed
            }

            books[count] = book;
            count++;
        }

        // Method to print all books
        public void PrintAllBooks()
        {
            Console.WriteLine("Hier sind die Bücher in deiner Versammlung:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i]);
            }
            Console.WriteLine();
        }

        // Method to print all books by a specific author
        public void PrintBooksByAuthor(string author)
        {
            Console.WriteLine($"Hier sind die Bücher von {author} in deiner Versammlung:");
            for (int i = 0; i < count; i++)
            {
                if (books[i].Author == author)
                {
                    Console.WriteLine(books[i]);
                }
            }
            Console.WriteLine();
        }

        // Method to remove all books by a specific author
        public void RemoveBooksByAuthor(string author)
        {
            int shift = 0; // 

            for (int i = 0; i < count; i++) 
            {
                if (books[i].Author == author) 
                {
                    shift++;
                }
                else if (shift > 0)
                {
                    books[i - shift] = books[i]; // shift the book to the left
                }
            }

            count -= shift;
            Array.Resize(ref books, count); // Resize the books array with the new length "count" 
        }
    }
}
