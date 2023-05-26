public class Priyanka
{
    private List<string> colorPalette;
    private string favoriteColor;

    public Priyanka(List<string> colorPalette, string favoriteColor)
    {
        this.colorPalette = colorPalette;
        this.favoriteColor = favoriteColor;
    }

    public void AddColor(string color)
    {
        // This method adds a color to Priyanka's palette
        if(!this.colorPalette.Contains(color))
        {
            this.colorPalette.Add(color);
        }
    }

    public bool IsColorInPalette(string color)
    {
        // This method checks if a color is in Priyanka's palette
        return this.colorPalette.Contains(color);
    }

    public string GetFavoriteColor()
    {
        // This method returns Priyanka's favorite color
        return this.favoriteColor;
    }

    public int CountColors()
    {
        // This method returns the number of colors in Priyanka's palette
        return this.colorPalette.Count;
    }
}

