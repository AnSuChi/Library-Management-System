using System;

namespace LibraryPublications;

public interface IPublication
{
    //Interface Members
    // Interface properties are implicitly PUBLIC. 
    // They only define the contract (signature) without any implementation.
    // Note: Interfaces should only expose PUBLIC methods and properties that are safe and intended for external use
    string Title { get; set; }
    string Author { get; set; }
    string Isbn { get; set; }
    DateOnly PublishedDate { get; set; }
    bool Available { get; set; }
}