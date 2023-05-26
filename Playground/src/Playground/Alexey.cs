public class Alexey
{
    private List<string> cameraCollection;
    private int photosTaken;

    public Alexey(List<string> cameraCollection)
    {
        this.cameraCollection = cameraCollection;
        this.photosTaken = 0;
    }

    public void TakePhoto(string camera)
    {
        // This method increases the number of photos taken if the camera is in Alexey's collection
        if(this.cameraCollection.Contains(camera))
        {
            this.photosTaken++;
        }
        else
        {
            throw new Exception("Camera not found in collection");
        }
    }

    public void AddCamera(string camera)
    {
        // This method adds a camera to Alexey's collection
        if(!this.cameraCollection.Contains(camera))
        {
            this.cameraCollection.Add(camera);
        }
    }

    public int GetPhotosTaken()
    {
        // This method returns the total number of photos taken by Alexey
        return this.photosTaken;
    }

    public bool HasCamera(string camera)
    {
        // This method checks if a camera is in Alexey's collection
        return this.cameraCollection.Contains(camera);
    }
}

