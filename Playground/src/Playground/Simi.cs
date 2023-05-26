public class Simi
{
    private int age;

    public Simi(int age)
    {
        this.age = age;
    }

    public int GetAgeInMonths()
    {
        return this.age * 12;
    }

    public bool IsAdult()
    {
        return this.age >= 18;
    }
}
