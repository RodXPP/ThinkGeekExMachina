public class Jeremy
{
    private List<string> movieWatchlist;
    private string currentlyWatching;

    public Jeremy(List<string> movieWatchlist)
    {
        this.movieWatchlist = movieWatchlist;
        this.currentlyWatching = "";
    }

    public void WatchMovie(string movie)
    {
        // This method sets the current movie Jeremy is watching
        if (this.movieWatchlist.Contains(movie))
        {
            this.currentlyWatching = movie;
        }
        else
        {
            throw new Exception("Movie not found in watchlist");
        }
    }

    public void AddMovieToWatchlist(string movie)
    {
        // This method adds a movie to Jeremy's watchlist
        if (!this.movieWatchlist.Contains(movie))
        {
            this.movieWatchlist.Add(movie);
        }
    }

    public string GetCurrentMovie()
    {
        // This method returns the movie Jeremy is currently watching
        return this.currentlyWatching;
    }

    public int CountMoviesInWatchlist()
    {
        // This method returns the number of movies in Jeremy's watchlist
        return this.movieWatchlist.Count;
    }
}

