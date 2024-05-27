using System;
namespace Aufgabe02_Büchersammlung
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _numberOfpages;

        public string Title
        {
            get { return _title; }
            init { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            init { _author = value; }
        }

        public int NumberOfPages
        {
            get { return _numberOfpages; }
            init { _numberOfpages = value; }
        }

        public Book(string title, string author, int numberOfPages)
        {
            this.Title = title;
            this.Author = author;
            this.NumberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            return $"Titel: {this.Title} Autor: {this.Author} Seitenzahl: {this.NumberOfPages}";
        }
    }
}

