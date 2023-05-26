public class Rod
{
    private double length;
    private double diameter;
    private string material;

    public Rod(double length, double diameter, string material)
    {
        this.length = length;
        this.diameter = diameter;
        this.material = material;
    }

    public double CalculateVolume()
    {
        // Volume of a cylinder = πr^2h
        return Math.PI * Math.Pow(diameter / 2, 2) * length;
    }

    public string GetMaterial()
    {
        return this.material;
    }

    public bool IsMetalRod()
    {
        // Simplified, consider any rod made from iron, steel or aluminum as a metal rod
        var metalMaterials = new List<string> { "iron", "steel", "aluminum" };
        return metalMaterials.Contains(this.material.ToLower());
    }
}

