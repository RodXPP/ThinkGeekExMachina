public class Renato
{
    private Dictionary<string, int> paintballGunInventory;

    public Renato()
    {
        this.paintballGunInventory = new Dictionary<string, int>();
    }

    public void AddPaintballGun(string gunModel, int quantity)
    {
        // This method adds a certain quantity of a paintball gun model to Renato's inventory
        if(this.paintballGunInventory.ContainsKey(gunModel))
        {
            this.paintballGunInventory[gunModel] += quantity;
        }
        else
        {
            this.paintballGunInventory[gunModel] = quantity;
        }
    }

    public bool HasPaintballGun(string gunModel)
    {
        // This method checks if a certain model of paintball gun is in Renato's inventory
        return this.paintballGunInventory.ContainsKey(gunModel);
    }

    public int CountPaintballGuns()
    {
        // This method returns the total number of paintball guns in Renato's inventory
        int total = 0;
        foreach (KeyValuePair<string, int> item in this.paintballGunInventory)
        {
            total += item.Value;
        }
        return total;
    }
}

