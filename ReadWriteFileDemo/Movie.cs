namespace ReadWriteFileDemo;

public class Movie
{
    public string Title { get; set; } = string.Empty;
    public double Length { get; set; }
    public string Description { get; set; } = string.Empty;
    public IEnumerable<Genres> Genres { get; set; } = new List<Genres>();

    public Movie(string title, double length, string description, List<Genres> genres)
    {
        Title = title;
        Length = length;
        Description = description;
        Genres = genres;
    }

    public Movie()
    {
        
    }

    //Overridar implementationen för ToString på Movie, alltså hur objekt av typen Movie beskrivs som text när man tex. gör Console.WriteLine(pulpFiction);
    public override string ToString()
    {
        var output = string.Empty;
        output += $"Title: {Title}\n";
        output += $"Length: {Length} hours\n";
        output += $"Description: {Description}\n";
        output += $"Genres: ";
        foreach (var genre in Genres)
        {
            output += $"{genre},";
        }
        output += "\n";
        return output;
    }

}