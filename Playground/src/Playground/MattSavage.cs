public class MattSavage
{
    private Dictionary<string, double> stockPortfolio;
    private double cash;

    public MattSavage(double initialCash)
    {
        this.stockPortfolio = new Dictionary<string, double>();
        this.cash = initialCash;
    }

    public void BuyStock(string stockSymbol, double price, double quantity)
    {
        // This method allows Matt to buy a certain quantity of a stock at a given price
        double totalCost = price * quantity;
        if (this.cash >= totalCost)
        {
            if (this.stockPortfolio.ContainsKey(stockSymbol))
            {
                this.stockPortfolio[stockSymbol] += quantity;
            }
            else
            {
                this.stockPortfolio[stockSymbol] = quantity;
            }
            this.cash -= totalCost;
        }
        else
        {
            throw new Exception("Insufficient funds to buy stock");
        }
    }

    public void SellStock(string stockSymbol, double price, double quantity)
    {
        // This method allows Matt to sell a certain quantity of a stock at a given price
        if (this.stockPortfolio.ContainsKey(stockSymbol) && this.stockPortfolio[stockSymbol] >= quantity)
        {
            this.stockPortfolio[stockSymbol] -= quantity;
            if (this.stockPortfolio[stockSymbol] == 0)
            {
                this.stockPortfolio.Remove(stockSymbol);
            }
            this.cash += price * quantity;
        }
        else
        {
            throw new Exception("Insufficient quantity to sell");
        }
    }

    public double GetPortfolioValue(double price)
    {
        // This method calculates the value of Matt's portfolio at a given price
        double portfolioValue = 0.0;
        foreach (KeyValuePair<string, double> stock in this.stockPortfolio)
        {
            portfolioValue += stock.Value * price;
        }
        return portfolioValue;
    }

    public double GetCash()
    {
        // This method returns the amount of cash Matt currently has
        return this.cash;
    }
}

