using Books;
using Authors;
using System.Net.Security;
using System.Net.Http.Headers;

// public Book(int bookId, string title, string isbn, string publisher, int year, string author)
var Book = new Book(1, "Gone", "9780755501618", "Electric Monkey", 2011, "Michael Grant");

Console.WriteLine($"The book \"{Book.Title}\", written by {Book.Author}, was published in {Book.Year} by {Book.Publisher}");
Console.WriteLine();Console.WriteLine();

bool exitApp = false;

Console.WriteLine("Hello, welcome to the basic @ss library!");
Console.WriteLine("To see a list of valid commands, type \"?\" into the console:");
Console.WriteLine();

while(!exitApp)
{
    Console.Write("> ");
    string? initialInput = Console.ReadLine();  // ? --> Nullable
    string? userInput = initialInput?.ToLower(); 
    
    switch (userInput)
    {
        case "?":
            Console.WriteLine("Valid commands:");
            Console.WriteLine("\"exit\" - Exit the console app");
            Console.WriteLine("\"add\" - Add entry");
            Console.WriteLine("\"rem\" - Removes entry");
            Console.WriteLine("\"show\" - Displays all entries in a list (Books/Authors)");
            Console.WriteLine();
            break;
        case "exit":
            Console.WriteLine("Exit App");
            exitApp = true;
            break;
        case "add":
            Console.WriteLine("Add");
            break;
        case "rem":
            Console.WriteLine("Remove");
            break;
        case "show":
            Console.WriteLine("Display");
            break;
        default:
            Console.WriteLine("Invalid input, please try again");
            Console.WriteLine();
            break;
    }
    Console.WriteLine();
}