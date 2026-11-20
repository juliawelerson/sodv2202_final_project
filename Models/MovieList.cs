namespace MovieCatalogApp.Models;

/// <summary>
/// A named, temporary list of movies (kept in memory only).
/// Owner: Julia
/// </summary>
public class MovieList
{
    private readonly List<Movie> movies = new();

    public string Name { get; }

    public MovieList(string name)
    {
        Name = name;
    }

    /// <summary>Returns a read-only view of the movies in this list.</summary>
    public IReadOnlyList<Movie> GetMovies()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds a movie. Returns false if a movie with the same Id is already in the list.
    /// </summary>
    public bool AddMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes the movie with this Id. Returns false if it isn't in the list.
    /// </summary>
    public bool RemoveMovie(int movieId)
    {
        throw new NotImplementedException();
    }
}
