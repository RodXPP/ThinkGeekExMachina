public class Simi
{
    private int numberOfPets;
    private string favoriteBook;
    private Dictionary<string, double> shoppingCart;

    public Simi(int numberOfPets, string favoriteBook)
    {
        this.numberOfPets = numberOfPets;
        this.favoriteBook = favoriteBook;
        this.shoppingCart = new Dictionary<string, double>();
    }

    public Simi(int numberOfPets, string favoriteBook, Dictionary<string, double> initialShoppingCart)
    {
        this.numberOfPets = numberOfPets;
        this.favoriteBook = favoriteBook;
        this.shoppingCart = new Dictionary<string, double>(initialShoppingCart);
    }

    public void AddToCart(string item, double price)
    {
        // This method adds an item to Simi's shopping cart
        if (this.shoppingCart.ContainsKey(item))
        {
            this.shoppingCart[item] += price;
        }
        else
        {
            this.shoppingCart[item] = price;
        }
    }

    public bool HasItemInCart(string item)
    {
        // This method checks if an item is in Simi's shopping cart
        return this.shoppingCart.ContainsKey(item);
    }

    public void RemoveFromCart(string item)
    {
        // This method removes an item from Simi's shopping cart
        if (this.shoppingCart.ContainsKey(item))
        {
            this.shoppingCart.Remove(item);
        }
        else
        {
            throw new Exception("Item not found in cart");
        }
    }

    public double GetTotalCartValue()
    {
        // This method calculates the total value of the items in Simi's shopping cart
        double total = 0.0;
        foreach (KeyValuePair<string, double> item in this.shoppingCart)
        {
            total += item.Value;
        }
        return total;
    }

    public int GetNumberOfPets()
    {
        // This method returns the number of pets Simi has
        return this.numberOfPets;
    }

    public string GetFavoriteBook()
    {
        // This method returns Simi's favorite book
        return this.favoriteBook;
    }
}

