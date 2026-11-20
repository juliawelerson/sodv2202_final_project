namespace MovieCatalogApp.UI;

/// <summary>
/// Movie-related menu features.
/// Owner: Otavio
/// </summary>
public partial class ConsoleMenu
{
    /// <summary>Prints all movies as a table: ID, title, year, genre.</summary>
    private void ShowMovies()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Asks for a title, shows the matches, or a friendly message when nothing matches.
    /// </summary>
    private void SearchMovies()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Asks for a movie ID (validated with int.TryParse) and prints all its fields.
    /// </summary>
    private void ShowMovieDetails()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Shared helper: shows the prompt and keeps asking until the user types a valid number.
    /// Also used by the list menus.
    /// </summary>
    private int ReadInt(string prompt)
    {
        throw new NotImplementedException();
    }
}
