public class Nahuel
{
    private List<string> bookCollection;
    private string currentlyReading;

    public Nahuel(List<string> bookCollection)
    {
        this.bookCollection = bookCollection;
        this.currentlyReading = "";
    }

    public void StartReading(string book)
    {
        // This method sets the current book Nahuel is reading
        if (this.bookCollection.Contains(book))
        {
            this.currentlyReading = book;
        }
        else
        {
            throw new Exception("Book not found in collection");
        }
    }

    public void AddBook(string book)
    {
        // This method adds a book to Nahuel's collection
        if (!this.bookCollection.Contains(book))
        {
            this.bookCollection.Add(book);
        }
    }

    public string GetCurrentBook()
    {
        // This method returns the book Nahuel is currently reading
        return this.currentlyReading;
    }

    public int CountBooks()
    {
        // This method returns the number of books in Nahuel's collection
        return this.bookCollection.Count;
    }
}

