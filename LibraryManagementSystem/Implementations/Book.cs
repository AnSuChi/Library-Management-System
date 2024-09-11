using System;

namespace Books;

public class Book
{

    // Fields
        //public int BookId;
        //public string Title;
        //public string Isbn;
        // ...

    // Properties
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Isbn { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }
    public string Author { get; set; }

    // Constructor - giving default values to fields
    public Book(int bookId, string title, string isbn, string publisher, int year, string author)
    {
        //Title = "Untitled";
        //Isbn = "0000000000000";
        //Publisher = "Unknown";
        //Author = "Unknown";

        BookId = bookId;
        Title = title;
        Isbn = isbn;
        Publisher = publisher;
        Year = year;
        Author = author;
    }
}