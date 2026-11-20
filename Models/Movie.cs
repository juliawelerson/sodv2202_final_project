namespace MovieCatalogApp.Models;

/// <summary>
/// One movie from movies.json.
/// Owner: Asen
/// </summary>
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Genre { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
