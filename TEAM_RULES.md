# Team rules (Phase 0)

These rules are agreed before anyone writes real logic. The stub classes follow them,
so everyone can code against the same signatures in parallel.

## Behaviour rules

1. **List names** are trimmed and compared case-insensitively.
   "Favs", "favs" and " FAVS " are the same list. An empty or blank name is rejected.
2. **Duplicate movie** means the same `Id`. A list can't hold two movies with the same `Id`.
3. **Not found returns `null`**: `MovieCatalog.GetMovieById` and `ListManager.GetList`
   return `null` when nothing matches. Callers must check for `null`.
4. **Add/remove/create/delete return `bool`**: `true` = it worked, `false` = it was rejected.
   The menu turns `false` into a clear message for the user.

## Who owns which file

| File | Owner |
| --- | --- |
| `Models/Movie.cs`, `Services/MovieCatalog.cs`, `Data/movies.json` | Asen |
| `Models/MovieList.cs`, `Services/ListManager.cs` | Julia |
| `UI/ConsoleMenu.Movies.cs` | Otavio |
| `Program.cs`, `UI/ConsoleMenu.cs`, `UI/ConsoleMenu.Lists.cs` | Anastasiia |

## Git workflow

- Never commit straight to `main`.
- One branch per person: `feature/catalog`, `feature/lists`, `feature/movie-menu`, `feature/main-menu`.
- Merge into `main` only through a pull request that one teammate reviews.
- Don't change a public method signature without telling the team first.
