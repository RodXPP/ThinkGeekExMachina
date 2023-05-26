public class Dahiron
{
    private int totalSteps;
    private bool isMusicPlaying;

    public Dahiron()
    {
        this.totalSteps = 0;
        this.isMusicPlaying = false;
    }

    public void StartMusic()
    {
        this.isMusicPlaying = true;
    }

    public void StopMusic()
    {
        this.isMusicPlaying = false;
    }

    public void Dance()
    {
        if(this.isMusicPlaying)
        {
            this.totalSteps += 100;
        }
        else
        {
            throw new Exception("This cuban can't dance without music!");
        }
    }

    public int GetTotalSteps()
    {
        return this.totalSteps;
    }

    public bool IsMusicPlaying()
    {
        return this.isMusicPlaying;
    }
}

