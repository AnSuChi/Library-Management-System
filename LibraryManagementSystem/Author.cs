using System;

namespace Authors;

public class Author
{
    public string AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string[] PublishedWork { get; }

    public Author(string authorId, string authorName, string[] publishedWork)
    {
        AuthorId = authorId;
        AuthorName = authorName;
        PublishedWork = publishedWork;
    }
}