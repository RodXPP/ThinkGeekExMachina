//The o Fan :)
public class Vince
{
    private Dictionary<string, string> musicAlbumRFIDCollection;
    private List<string> favoriteAlbums;

    public Vince()
    {
        this.musicAlbumRFIDCollection = new Dictionary<string, string>();
        this.favoriteAlbums = new List<string>();
    }

    public void AddAlbumWithRFID(string albumName, string RFID)
    {
        // This method adds a music LP album with its RFID to Vince's collection
        if(!this.musicAlbumRFIDCollection.ContainsKey(albumName))
        {
            this.musicAlbumRFIDCollection[albumName] = RFID;
        }
        else
        {
            throw new Exception("Album already in collection");
        }
    }

    public bool HasAlbum(string albumName)
    {
        // This method checks if a music LP album is in Vince's collection
        return this.musicAlbumRFIDCollection.ContainsKey(albumName);
    }

    public string GetRFIDForAlbum(string albumName)
    {
        // This method returns the RFID for a music LP album in Vince's collection
        if(this.musicAlbumRFIDCollection.ContainsKey(albumName))
        {
            return this.musicAlbumRFIDCollection[albumName];
        }
        else
        {
            throw new Exception("Album not found in collection");
        }
    }

    public void AddFavoriteAlbum(string albumName)
    {
        // This method adds a music LP album to Vince's favorite albums
        if (this.HasAlbum(albumName) && !this.favoriteAlbums.Contains(albumName))
        {
            this.favoriteAlbums.Add(albumName);
        }
    }

    public bool IsFavoriteAlbum(string albumName)
    {
        // This method checks if a music LP album is in Vince's favorite albums
        return this.favoriteAlbums.Contains(albumName);
    }

    public int CountAlbumsInCollection()
    {
        // This method returns the number of music LP albums in Vince's collection
        return this.musicAlbumRFIDCollection.Count;
    }
}

