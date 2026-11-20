using MovieCatalogApp.Services;

namespace MovieCatalogApp.UI;

/// <summary>
/// Console menu. This is a partial class split across three files so two people
/// can work on it without merge conflicts:
///   ConsoleMenu.cs        - fields, constructor, main menu loop (Owner: Anastasiia)
///   ConsoleMenu.Movies.cs - browse, search, details          (Owner: Otavio)
///   ConsoleMenu.Lists.cs  - list management submenu          (Owner: Anastasiia)
/// </summary>
public partial class ConsoleMenu
{
    private readonly MovieCatalog catalog;
    private readonly ListManager listManager;

    public ConsoleMenu(MovieCatalog catalog, ListManager listManager)
    {
        this.catalog = catalog;
        this.listManager = listManager;
    }

    /// <summary>
    /// Main menu loop: browse, search, details, manage lists, exit.
    /// Invalid choices show a message and the menu again.
    /// </summary>
    public void Run()
    {
        throw new NotImplementedException();
    }
}
