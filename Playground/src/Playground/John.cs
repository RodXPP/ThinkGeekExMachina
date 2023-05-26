public class John
{
    private string favoriteBook;

    public John(string favoriteBook)
    {
        this.favoriteBook = favoriteBook;
    }

    public string GetFavoriteBook()
    {
        return this.favoriteBook;
    }

    public bool IsFavoriteBookNonFiction()
    {
        // Assuming the book title contains the genre
        return this.favoriteBook.ToLower().Contains("non-fiction");
    }
}
