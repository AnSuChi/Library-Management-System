using System;


namespace LibraryPublications;

public class Book : IPublication
{
    //Fields: 
    // Variables declared directly in a class or struct --> used to store data and represent the state of an object.

    //Properties:
    // Provide a way to access and modify the values of fields (controlled access). They act as an intermediary between the data and the outside world.
    public string Title { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }
    public DateOnly PublishedDate { get; set; }
    public bool Available { get; set; }


    // Constructor - giving default/initialization values to fields
    public Book(string title, string author, string isbn, DateOnly publishedDate, bool available) 
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        PublishedDate = publishedDate;
        Available = available;
    }

}