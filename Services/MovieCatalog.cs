using MovieCatalogApp.Models;

namespace MovieCatalogApp.Services;

/// <summary>
/// Loads movies from movies.json and lets the app browse and search them.
/// Owner: Asen
/// </summary>
public class MovieCatalog
{
    private List<Movie> movies = new();

    /// <summary>
    /// Reads the JSON file asynchronously into the movies list.
    /// A missing file or invalid JSON should show an error message, not crash the app.
    /// </summary>
    public Task LoadMoviesAsync(string filePath)
    {
        throw new NotImplementedException();
    }

    /// <summary>Returns a read-only view of all movies.</summary>
    public IReadOnlyList<Movie> GetAllMovies()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Case-insensitive partial match on Title ("inter" finds "Interstellar").
    /// Blank input returns an empty list.
    /// </summary>
    public List<Movie> SearchMovies(string title)
    {
        throw new NotImplementedException();
    }

    /// <summary>Returns the movie with this Id, or null if there is none.</summary>
    public Movie? GetMovieById(int id)
    {
        throw new NotImplementedException();
    }
}
