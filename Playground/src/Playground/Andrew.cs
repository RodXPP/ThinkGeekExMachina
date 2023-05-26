public class Andrew
{
    private string favoriteColor;
    private List<string> hobbies;

    public Andrew(string favoriteColor, List<string> hobbies)
    {
        this.favoriteColor = favoriteColor;
        this.hobbies = hobbies;
    }

    public string GetFavoriteColor()
    {
        return this.favoriteColor;
    }

    public bool HasHobby(string hobby)
    {
        // This method checks if Andrew has a given hobby
        return this.hobbies.Contains(hobby);
    }

    public int CountHobbies()
    {
        // This method returns the number of hobbies Andrew has
        return this.hobbies.Count;
    }

    public void AddHobby(string newHobby)
    {
        // This method adds a new hobby to Andrew's list of hobbies
        if(!this.hobbies.Contains(newHobby))
        {
            this.hobbies.Add(newHobby);
        }
    }
}

