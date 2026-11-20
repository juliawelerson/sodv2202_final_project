using MovieCatalogApp.Models;

namespace MovieCatalogApp.Services;

/// <summary>
/// Creates, finds and deletes the user's temporary movie lists.
/// Owner: Julia
/// </summary>
public class ListManager
{
    private readonly List<MovieList> lists = new();

    /// <summary>
    /// Trims the name, then creates the list.
    /// Returns false if the name is empty or a list with that name already exists
    /// (compared case-insensitively, so "Favs" and "favs " are the same).
    /// </summary>
    public bool CreateList(string name)
    {
        throw new NotImplementedException();
    }

    /// <summary>Returns a read-only view of all lists.</summary>
    public IReadOnlyList<MovieList> GetLists()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Finds a list by name (trimmed, case-insensitive). Returns null if not found.
    /// </summary>
    public MovieList? GetList(string name)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Deletes a list by name (trimmed, case-insensitive). Returns false if not found.
    /// </summary>
    public bool DeleteList(string name)
    {
        throw new NotImplementedException();
    }
}
