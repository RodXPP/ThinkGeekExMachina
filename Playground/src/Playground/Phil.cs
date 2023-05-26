public class Phil
{
    private List<string> programmingLanguages;
    private int yearsOfExperience;

    public Phil(List<string> programmingLanguages, int yearsOfExperience)
    {
        this.programmingLanguages = programmingLanguages;
        this.yearsOfExperience = yearsOfExperience;
    }

    public bool KnowsLanguage(string language)
    {
        // This method checks if Phil knows a given programming language
        return this.programmingLanguages.Contains(language);
    }

    public int HowManyLanguages()
    {
        // This method returns the number of programming languages Phil knows
        return this.programmingLanguages.Count;
    }

    public bool IsSeniorDeveloper()
    {
        // This method checks if Phil is a senior developer based on his years of experience
        return this.yearsOfExperience >= 5;
    }
}

