
public class Pizza : IComparable<Pizza>
{
    public string Name { get; set; }
    public int Calories { get; set; }

    public Pizza(string name, int calories)
    {
        Name = name;
        Calories = calories;
    }

    public int CompareTo(Pizza? other)
    {
        if (other == null)
            return 1;

        return this.Calories.CompareTo(other.Calories);
    }
}
