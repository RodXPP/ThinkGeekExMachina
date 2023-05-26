public class Aamir
{
    private double speed;
    private double distanceCovered;

    public Aamir(double speed)
    {
        this.speed = speed;
        this.distanceCovered = 0.0;
    }

    public void Run(double time)
    {
        // This method calculates the distance covered by Aamir when running for a certain amount of time
        this.distanceCovered += time * this.speed;
    }

    public double GetDistanceCovered()
    {
        // This method returns the total distance covered by Aamir
        return this.distanceCovered;
    }

    public bool IsMarathonCompleted()
    {
        // This method checks if Aamir has completed a marathon (42.195 kilometers)
        return this.distanceCovered >= 42.195;
    }
}

