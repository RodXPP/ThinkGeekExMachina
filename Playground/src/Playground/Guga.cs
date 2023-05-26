public class Guga
{
    private List<string> motorbikeCollection;

    public Guga()
    {
        this.motorbikeCollection = new List<string>();
    }

    public void AddMotorbike(string motorbike)
    {
        // This method adds a motorbike to Guga's collection
        if (!this.motorbikeCollection.Contains(motorbike))
        {
            this.motorbikeCollection.Add(motorbike);
        }
    }

    public bool HasMotorbike(string motorbike)
    {
        // This method checks if a motorbike is in Guga's collection
        return this.motorbikeCollection.Contains(motorbike);
    }

    public void RemoveMotorbike(string motorbike)
    {
        // This method removes a motorbike from Guga's collection
        if (this.motorbikeCollection.Contains(motorbike))
        {
            this.motorbikeCollection.Remove(motorbike);
        }
    }

    public int CountMotorbikes()
    {
        // This method returns the number of motorbikes in Guga's collection
        return this.motorbikeCollection.Count;
    }
}

